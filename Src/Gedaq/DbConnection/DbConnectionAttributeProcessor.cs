using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection;
using Gedaq.Enums;
using System.Threading;
using Gedaq.DbConnection.Model;
using Gedaq.DbConnection.Generators;
using Gedaq.Base;
using Gedaq.Base.Model;

namespace Gedaq.Npgsql
{
    internal class DbConnectionAttributeProcessor
    {
        private List<DbQuery> _read = new List<DbQuery>();
        private List<DbQueryBatch> _readBatch = new List<DbQueryBatch>();

        Dictionary<string, DbQuery> _readTemp = new Dictionary<string, DbQuery>();
        Dictionary<string, List<DbParametr>> _parametrsTemp = new Dictionary<string, List<DbParametr>>();
        private List<DbQueryBatch> _batchTemp = new List<DbQueryBatch>();
        private Dictionary<string, List<BatchPart>> _batchParts = new Dictionary<string, List<BatchPart>>();

        private QueryParser _queryParser = new QueryParser();

        public bool ProcessAttributes(ImmutableArray<AttributeData> attributes, INamedTypeSymbol containsType)
        {
            foreach (var attribute in attributes)
            {
                if (attribute.AttributeClass.IsAssignableFrom("Gedaq.DbConnection.Attributes", "QueryAttribute"))
                {
                    ProcessQueryRead(attribute, containsType);
                    continue;
                }

                if (attribute.AttributeClass.IsAssignableFrom("Gedaq.DbConnection.Attributes", "ParametrAttribute"))
                {
                    ProcessParametr(attribute, containsType);
                    continue;
                }

                if (attribute.AttributeClass.IsAssignableFrom("Gedaq.DbConnection.Attributes", "QueryBatchAttribute"))
                {
                    ProcessBatch(attribute, containsType);
                    continue;
                }

                if (attribute.AttributeClass.IsAssignableFrom("Gedaq.DbConnection.Attributes", "BatchPartAttribute"))
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
                DbQuery firstRead = null;
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
            foreach (var read in _readTemp.Values)
            {
                if (_parametrsTemp.TryGetValue(read.MethodName, out var parametrs))
                {
                    read.Parametrs = parametrs.ToArray();
                }

                if (read.QueryType == QueryType.Read)
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
            if (!DbQueryBatch.CreateNew(parametrAttribute.ConstructorArguments, containsType, out var queryBatch))
            {
                throw new Exception($"Unknown {nameof(DbQueryBatch)} constructor");
            }

            _batchTemp.Add(queryBatch);
        }

        private void ProcessBatchPart(AttributeData parametrAttribute, INamedTypeSymbol containsType)
        {
            if (!BatchPart.CreateNew(parametrAttribute.ConstructorArguments, out var batchPart))
            {
                throw new Exception($"Unknown {nameof(BatchPart)} constructor");
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
            if (!DbQuery.CreateNew(queryReadAttribute.ConstructorArguments, containsType, out var queryReadMethod))
            {
                throw new Exception($"Unknown {nameof(DbQuery)} constructor");
            }

            if(_readTemp.ContainsKey(queryReadMethod.MethodName))
            {
                throw new Exception("Request with duplicate name");
            }

            _readTemp[queryReadMethod.MethodName] = queryReadMethod;
        }

        private void ProcessParametr(AttributeData parametrAttribute, INamedTypeSymbol containsType)
        {
            if (!DbParametr.CreateNew(parametrAttribute.ConstructorArguments, containsType, out var parametr, out var methodName))
            {
                throw new Exception($"Unknown {nameof(DbParametr)} constructor");
            }

            if (!_parametrsTemp.ContainsKey(methodName))
            {
                var methods = new List<DbParametr>();
                _parametrsTemp.Add(methodName, methods);
            }

            _parametrsTemp[methodName].Add(parametr);
        }

        public void GenerateAndSaveMethods(GeneratorExecutionContext context)
        {
            var readGenerator = new DbQueryGenerator();
            foreach (var queryRead in _read)
            {
                readGenerator.Generate(queryRead);
                context.AddSource($"{queryRead.MethodName}DbConnectionExtension.g.cs", readGenerator.GetCode());
            }
            _read.Clear();

            var batchReadGenerator = new DbQueryBatchGenerator();
            foreach (var batchRead in _readBatch)
            {
                batchReadGenerator.Generate(batchRead);
                context.AddSource($"{batchRead.MethodName}DbConnectionExtension.g.cs", batchReadGenerator.GetCode());
            }
            _readBatch.Clear();
        }
    }
}