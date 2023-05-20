using Gedaq.Base;
using Gedaq.Base.Model;
using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.MySqlConnector.GeneratorsBatch;
using Gedaq.MySqlConnector.GeneratorsQuery;
using Gedaq.MySqlConnector.Model;
using Gedaq.Parser;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Gedaq.MySqlConnector
{
    internal class MySqlConnectorAttributeProcessor : BaseAttributeProcessor
    {
        private List<MySqlConnectorQuery> _read = new List<MySqlConnectorQuery>();
        private List<MySqlConnectorQueryBatch> _readBatch = new List<MySqlConnectorQueryBatch>();

        Dictionary<string, MySqlConnectorQuery> _readTemp = new Dictionary<string, MySqlConnectorQuery>();
        Dictionary<string, List<MySqlConnectorParametr>> _parametrsTemp = new Dictionary<string, List<MySqlConnectorParametr>>();
        private List<MySqlConnectorQueryBatch> _batchTemp = new List<MySqlConnectorQueryBatch>();
        private Dictionary<string, List<BatchPart>> _batchParts = new Dictionary<string, List<BatchPart>>();

        private QueryParser _queryParser = new QueryParser();

        public void ProcessAttributes(SyntaxList<AttributeListSyntax> attributes, Compilation compilation, INamedTypeSymbol containsType)
        {
            foreach (var attributeListSyntax in attributes)
            {
                var parentSymbol = attributeListSyntax.Parent.GetDeclaredSymbol(compilation);
                var parentAttributes = parentSymbol.GetAttributes();
                foreach (var attributeSyntax in attributeListSyntax.Attributes)
                {
                    var attributeData = parentAttributes.First(f => f.ApplicationSyntaxReference.GetSyntax() == attributeSyntax);
                    if (attributeData.AttributeClass.IsAssignableFrom("Gedaq.MySqlConnector.Attributes", "QueryAttribute"))
                    {
                        ProcessQueryRead(attributeData, containsType);
                        continue;
                    }

                    if (attributeData.AttributeClass.IsAssignableFrom("Gedaq.MySqlConnector.Attributes", "ParametrAttribute"))
                    {
                        ProcessParametr(attributeData, containsType);
                        continue;
                    }

                    if (attributeData.AttributeClass.IsAssignableFrom("Gedaq.MySqlConnector.Attributes", "QueryBatchAttribute"))
                    {
                        ProcessBatch(attributeData, containsType);
                        continue;
                    }

                    if (attributeData.AttributeClass.IsAssignableFrom("Gedaq.MySqlConnector.Attributes", "BatchPartAttribute"))
                    {
                        ProcessBatchPart(attributeData, containsType);
                        continue;
                    }

                    base.ProcessAttribute(attributeData, containsType);
                }
            }
        }

        public void CompleteProcessContainTypes()
        {
            FillReadMethods();
            _parametrsTemp.Clear();
            _formatsTemp.Clear();

            FillBatches();
            _readTemp.Clear();
        }

        private void FillBatches()
        {
            foreach (var batch in _batchTemp)
            {
                if (!_batchParts.TryGetValue(batch.MethodName, out var batchParts))
                {
                    throw new Exception($"There are no requests in the batch: '{batch.MethodName}'");
                }
                _batchParts.Remove(batch.MethodName);

                var set = new HashSet<int>();
                MySqlConnectorQuery firstRead = null;
                foreach (var part in batchParts.OrderBy(or => or.BatchNumber))
                {
                    if (!set.Add(part.BatchNumber))
                    {
                        throw new Exception($"Batch number must be unique in batch:'{part.BatchName}'");
                    }

                    if (!_readTemp.TryGetValue(part.MethodName, out var queryRead))
                    {
                        throw new Exception($"Request for batch not found.:'{part.MethodName}'");
                    }

                    if (firstRead == null)
                    {
                        firstRead = queryRead;
                    }

                    batch.AllSameTypes &= SymbolEqualityComparer.Default.Equals(firstRead.MapTypeName, queryRead.MapTypeName);
                    batch.HaveParametrs |= queryRead.HaveParametrs();
                    batch.HaveFormatParametrs |= queryRead.HaveFromatParametrs();
                    batch.Queries.Add((part.BatchNumber, queryRead));
                }

                _readBatch.Add(batch);
            }

            _batchTemp.Clear();
            if (_batchParts.Count != 0)
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
                AddFormatParametrs(read);

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
            if (!MySqlConnectorQueryBatch.CreateNew(parametrAttribute.ConstructorArguments, containsType, out var queryBatch))
            {
                throw new Exception($"Unknown {nameof(MySqlConnectorQueryBatch)} constructor");
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
            if (!MySqlConnectorQuery.CreateNew(queryReadAttribute.ConstructorArguments, containsType, out var queryReadMethod))
            {
                throw new Exception($"Unknown {nameof(MySqlConnectorQuery)} constructor");
            }

            if (_readTemp.ContainsKey(queryReadMethod.MethodName))
            {
                throw new Exception("Request with duplicate name");
            }

            _readTemp[queryReadMethod.MethodName] = queryReadMethod;
        }

        private void ProcessParametr(AttributeData parametrAttribute, INamedTypeSymbol containsType)
        {
            if (!MySqlConnectorParametr.CreateNew(parametrAttribute.ConstructorArguments, containsType, out var parametr, out var methodName))
            {
                throw new Exception($"Unknown {nameof(MySqlConnectorParametr)} constructor");
            }

            if (!_parametrsTemp.ContainsKey(methodName))
            {
                var methods = new List<MySqlConnectorParametr>();
                _parametrsTemp.Add(methodName, methods);
            }

            _parametrsTemp[methodName].Add(parametr);
        }

        public void GenerateAndSaveMethods(SourceProductionContext context)
        {
            var readGenerator = new MySqlConnectorQueryGenerator();
            foreach (var queryRead in _read)
            {
                readGenerator.GenerateMethod(queryRead);
                context.AddSource($"{queryRead.MethodName}MySqlConnectorExtension.g.cs", readGenerator.GetCode());
            }
            _read.Clear();

            var batchReadGenerator = new MySqlConnectorQueryBatchGenerator();
            foreach (var batchRead in _readBatch)
            {
                batchReadGenerator.GenerateMethod(batchRead);
                context.AddSource($"{batchRead.MethodName}MySqlConnectorExtension.g.cs", batchReadGenerator.GetCode());
            }
            _readBatch.Clear();
        }
    }
}