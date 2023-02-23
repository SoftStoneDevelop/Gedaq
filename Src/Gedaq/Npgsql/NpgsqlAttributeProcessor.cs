﻿using Gedaq.Base.Model;
using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.Npgsql.GeneratorsBatch;
using Gedaq.Npgsql.GeneratorsQuery;
using Gedaq.Npgsql.Model;
using Gedaq.Npgsql.Parser;
using Gedaq.Parser;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Gedaq.Npgsql
{
    internal class NpgsqlAttributeProcessor
    {
        private List<NpgsqlQuery> _read = new List<NpgsqlQuery>();
        private List<NpgsqlQueryBatch> _readBatch = new List<NpgsqlQueryBatch>();
        private List<BinaryExport> _binaryExports = new List<BinaryExport>();

        Dictionary<string, NpgsqlQuery> _readTemp = new Dictionary<string,NpgsqlQuery>();
        Dictionary<string, List<NpgsqlParametr>> _parametrsTemp = new Dictionary<string, List<NpgsqlParametr>>();
        private List<NpgsqlQueryBatch> _batchTemp = new List<NpgsqlQueryBatch>();
        private Dictionary<string, List<BatchPart>> _batchParts = new Dictionary<string, List<BatchPart>>();

        private QueryParser _queryParser = new QueryParser();
        private BinaryParser _binaryParser = new BinaryParser();

        public bool ProcessAttributes(ImmutableArray<AttributeData> attributes, INamedTypeSymbol containsType)
        {
            foreach (var attribute in attributes)
            {
                if (attribute.AttributeClass.IsAssignableFrom("Gedaq.Npgsql.Attributes", "QueryAttribute"))
                {
                    ProcessQueryRead(attribute, containsType);
                    continue;
                }

                if (attribute.AttributeClass.IsAssignableFrom("Gedaq.Npgsql.Attributes", "ParametrAttribute"))
                {
                    ProcessParametr(attribute, containsType);
                    continue;
                }

                if (attribute.AttributeClass.IsAssignableFrom("Gedaq.Npgsql.Attributes", "QueryBatchAttribute"))
                {
                    ProcessBatch(attribute, containsType);
                    continue;
                }

                if (attribute.AttributeClass.IsAssignableFrom("Gedaq.Npgsql.Attributes", "BatchPartAttribute"))
                {
                    ProcessBatchPart(attribute, containsType);
                    continue;
                }

                if (attribute.AttributeClass.IsAssignableFrom("Gedaq.Npgsql.Attributes", "BinaryExportAttribute"))
                {
                    ProcessBatchPart(attribute, containsType);
                    continue;
                }
            }

            return false;
        }

        public void CompleteProcessContainTypes()
        {
            FillReadMethods();
            _parametrsTemp.Clear();

            FillBatches();
            _readTemp.Clear();
        }

        private void FillBatches()
        {
            foreach (var batch in _batchTemp)
            {
                if(!_batchParts.TryGetValue(batch.MethodName, out var batchParts))
                {
                    throw new Exception($"There are no requests in the batch: '{batch.MethodName}'");
                }
                _batchParts.Remove(batch.MethodName);

                var set = new HashSet<int>();
                NpgsqlQuery firstRead = null;
                foreach (var part in batchParts.OrderBy(or => or.BatchNumber))
                {
                    if (!set.Add(part.BatchNumber))
                    {
                        throw new Exception($"Batch number must be unique in batch:'{part.BatchName}'");
                    }

                    if(!_readTemp.TryGetValue(part.MethodName, out var queryRead))
                    {
                        throw new Exception($"Request for batch not found.:'{part.MethodName}'");
                    }

                    if(firstRead == null)
                    {
                        firstRead = queryRead;
                    }

                    batch.AllSameTypes &= SymbolEqualityComparer.Default.Equals(firstRead.MapTypeName, queryRead.MapTypeName);
                    batch.HaveParametrs |= queryRead.HaveParametrs();
                    batch.SourceType |= queryRead.SourceType;
                    batch.Queries.Add((part.BatchNumber, queryRead));
                }

                _readBatch.Add(batch);
            }

            _batchTemp.Clear();
            if(_batchParts.Count != 0)
            {
                throw new Exception($"Batch part without batch");
            }
        }

        private void FillReadMethods()
        {
            var set = new HashSet<int>();
            foreach (var read in _readTemp.Values)
            {
                if (_parametrsTemp.TryGetValue(read.MethodName, out var parametrs))
                {
                    parametrs = parametrs.OrderBy(or => or.Position).ToList();
                    read.Parametrs = new NpgsqlParametr[parametrs.Count];

                    set.Clear();
                    var containNamedParametr = false;
                    var containPositionParametr = false;
                    for (int i = 0; i < parametrs.Count; i++)
                    {
                        var parametr = parametrs[i];
                        if (parametr.HavePosition)
                        {
                            if (!set.Add(parametr.Position))
                            {
                                throw new Exception("Parametr position must be unique");
                            }

                            containPositionParametr |= true;
                        }
                        else
                        {
                            parametr.Position = i + 1;
                        }

                        containNamedParametr |= parametr.HaveName;

                        read.Parametrs[i] = parametr;
                    }

                    if (containNamedParametr && containPositionParametr)
                    {
                        throw new Exception("Parameters in query can be positional or named, but not combined");
                    }
                }

                if(read.QueryType == QueryType.Read)
                {
                    read.Aliases = _queryParser.Parse(ref read.Query);
                }
                else
                {
                    read.Aliases = _queryParser.GetIntResultAlias();
                }

                if (read.NeedGenerate)
                {
                    _read.Add(read);
                }
            }
        }

        private void ProcessBatch(AttributeData parametrAttribute, INamedTypeSymbol containsType)
        {
            if (!NpgsqlQueryBatch.CreateNew(parametrAttribute.ConstructorArguments, containsType, out var queryBatch))
            {
                throw new Exception($"Unknown {nameof(NpgsqlParametr)} constructor");
            }

            _batchTemp.Add(queryBatch);
        }

        private void ProcessBatchPart(AttributeData parametrAttribute, INamedTypeSymbol containsType)
        {
            if (!BatchPart.CreateNew(parametrAttribute.ConstructorArguments, out var batchPart))
            {
                throw new Exception($"Unknown {nameof(NpgsqlParametr)} constructor");
            }

            if (!_batchParts.TryGetValue(batchPart.BatchName, out var parts))
            {
                parts = new List<BatchPart>();
                _batchParts.Add(batchPart.BatchName, parts);
            }

            parts.Add(batchPart);
        }

        private void ProcessQueryRead(AttributeData queryReadAttribute, INamedTypeSymbol containsType)
        {
            if (!NpgsqlQuery.CreateNew(queryReadAttribute.ConstructorArguments, containsType, out var queryReadMethod))
            {
                throw new Exception($"Unknown {nameof(NpgsqlQuery)} constructor");
            }

            if(_readTemp.ContainsKey(queryReadMethod.MethodName))
            {
                throw new Exception("Request with duplicate name");
            }

            _readTemp[queryReadMethod.MethodName] = queryReadMethod;
        }

        private void ProcessParametr(AttributeData parametrAttribute, INamedTypeSymbol containsType)
        {
            if (!NpgsqlParametr.CreateNew(parametrAttribute.ConstructorArguments, containsType, out var parametr, out var methodName))
            {
                throw new Exception($"Unknown {nameof(NpgsqlParametr)} constructor");
            }

            if (!_parametrsTemp.ContainsKey(methodName))
            {
                var methods = new List<NpgsqlParametr>();
                _parametrsTemp.Add(methodName, methods);
            }

            _parametrsTemp[methodName].Add(parametr);
        }

        private void ProcessBinaryExport(AttributeData queryReadAttribute, INamedTypeSymbol containsType)
        {
            if (!BinaryExport.CreateNew(queryReadAttribute.ConstructorArguments, containsType, out var binaryExport))
            {
                throw new Exception($"Unknown {nameof(BinaryExport)} constructor");
            }

            binaryExport.Aliases = _binaryParser.Parse(ref binaryExport.Query);
            _binaryExports.Add(binaryExport);
        }

        public void GenerateAndSaveMethods(GeneratorExecutionContext context)
        {
            var readGenerator = new NpgsqlQueryGenerator();
            foreach (var queryRead in _read)
            {
                readGenerator.GenerateMethod(queryRead);
                context.AddSource($"{queryRead.MethodName}NpgsqlExtension.g.cs", readGenerator.GetCode());
            }
            _read.Clear();

            var batchReadGenerator = new NpgsqlQueryBatchGenerator();
            foreach (var batchRead in _readBatch)
            {
                batchReadGenerator.GenerateMethod(batchRead);
                context.AddSource($"{batchRead.MethodName}NpgsqlExtension.g.cs", batchReadGenerator.GetCode());
            }
            _readBatch.Clear();
        }
    }
}