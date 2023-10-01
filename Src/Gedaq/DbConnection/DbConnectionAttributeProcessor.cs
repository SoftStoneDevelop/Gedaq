using Gedaq.Base;
using Gedaq.Base.Model;
using Gedaq.DbConnection.GeneratorsBatch;
using Gedaq.DbConnection.GeneratorsQuery;
using Gedaq.DbConnection.Model;
using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.Parser;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Gedaq.Npgsql
{
    internal class DbConnectionAttributeProcessor : BaseAttributeProcessor
    {
        private List<DbQuery> _read = new List<DbQuery>();
        private List<DbQueryBatch> _readBatch = new List<DbQueryBatch>();

        private List<BatchPair<DbQueryBatch>> _batchPairTemp = new List<BatchPair<DbQueryBatch>>();
        private Dictionary<string, DbQuery> _readContainsType = new Dictionary<string, DbQuery>();

        private QueryParser _queryParser = new QueryParser();

        public override void ProcessAttributes(
            SyntaxList<AttributeListSyntax> attributes, 
            Compilation compilation, 
            INamedTypeSymbol containsType, 
            CancellationToken cancellationToken
            )
        {
            foreach (var attributeListSyntax in attributes)
            {
                cancellationToken.ThrowIfCancellationRequested();
                var parentSymbol = attributeListSyntax.Parent.GetDeclaredSymbol(compilation);
                var parentAttributes = parentSymbol.GetAttributes();

                var batchPair = new BatchPair<DbQueryBatch>();
                var readTemp = new ReadPair<DbQuery, DbParametr>();
                foreach (var attributeSyntax in attributeListSyntax.Attributes)
                {
                    cancellationToken.ThrowIfCancellationRequested();
                    var attributeData = parentAttributes.First(f => f.ApplicationSyntaxReference.GetSyntax() == attributeSyntax);

                    if (attributeData.AttributeClass.IsAssignableFrom("Gedaq.DbConnection.Attributes", "QueryAttribute"))
                    {
                        ProcessQueryRead(attributeData, containsType, readTemp);
                        continue;
                    }

                    if (attributeData.AttributeClass.IsAssignableFrom("Gedaq.DbConnection.Attributes", "ParametrAttribute"))
                    {
                        ProcessParametr(attributeData, containsType, readTemp);
                        continue;
                    }

                    if (attributeData.AttributeClass.IsAssignableFrom("Gedaq.DbConnection.Attributes", "QueryBatchAttribute"))
                    {
                        ProcessBatch(attributeData, containsType, batchPair);
                        continue;
                    }

                    if (attributeData.AttributeClass.IsAssignableFrom("Gedaq.DbConnection.Attributes", "BatchPartAttribute"))
                    {
                        ProcessBatchPart(attributeData, containsType, batchPair);
                        continue;
                    }

                    base.ProcessAttribute(attributeData, containsType, readTemp.FormatParametrs);
                }

                TryAddReadMethod(readTemp);
                TryAddBatchToTemp(batchPair);
            }
        }

        public override void CompleteProcessContainTypes()
        {
            FillBatches();
        }

        private void TryAddBatchToTemp(BatchPair<DbQueryBatch> candidatePair)
        {
            if (candidatePair.IsEmpty())
            {
                return;
            }

            if (!candidatePair.Parts.Any())
            {
                throw new Exception($"Batch query must contain batch parts:'{candidatePair.Batch.MethodName}'");
            }

            if (candidatePair.Batch == null)
            {
                throw new Exception($"Batch query must contain batch parts:'{candidatePair.Batch.MethodName}'");
            }

            _batchPairTemp.Add(candidatePair);
        }

        private void FillBatches()
        {
            foreach (var batchPair in _batchPairTemp)
            {
                DbQuery firstRead = null;

                var set = new HashSet<int>();
                var queries = new List<BatchPart<DbQuery>>();
                foreach (var part in batchPair.Parts.OrderBy(or => or.BatchNumber))
                {
                    if (!set.Add(part.BatchNumber))
                    {
                        throw new Exception($"Batch number must be unique in batch:'{batchPair.Batch.MethodName}'");
                    }

                    if(!_readContainsType.TryGetValue(part.MethodName, out var queryRead))
                    {
                        throw new Exception($"Request for batch not found:'{part.MethodName}'");
                    }

                    if(firstRead == null)
                    {
                        firstRead = queryRead;
                    }

                    batchPair.Batch.AllSameTypes &= SymbolEqualityComparer.Default.Equals(firstRead.MapTypeName, queryRead.MapTypeName);
                    batchPair.Batch.HaveParametrs |= queryRead.HaveParametrs();
                    batchPair.Batch.HaveFormatParametrs |= queryRead.HaveFromatParametrs();
                    queries.Add(new BatchPart<DbQuery>(queryRead, part.BatchNumber));
                }

                batchPair.Batch.Queries = queries.OrderBy(or => or.Number).ToArray();
                for (int i = 0; i < batchPair.Batch.Queries.Length; i++)
                {
                    batchPair.Batch.Queries[i].Index = i;
                }

                _readBatch.Add(batchPair.Batch);
            }

            _batchPairTemp.Clear();
            _readContainsType.Clear();
        }

        private void TryAddReadMethod(ReadPair<DbQuery, DbParametr> readPair)
        {
            if (readPair.IsEmpty())
            {
                return;
            }

            var query = readPair.Query;
            query.Parametrs = readPair.Parametrs.ToArray();
            for (int i = 0; i < query.Parametrs.Length; i++)
            {
                query.Parametrs[i].Index = i;
            }
            AddFormatParametrs(query, readPair.FormatParametrs);

            if (query.QueryType == QueryType.NonQuery)
            {
                query.Aliases = _queryParser.GetIntResultAlias();
            }
            else
            {
                query.Aliases = _queryParser.Parse(ref query.Query);
            }

            if (query.NeedGenerate)
            {
                _read.Add(query);
            }

            _readContainsType.Add(query.MethodName, query);
        }

        private void ProcessBatch(AttributeData parametrAttribute, INamedTypeSymbol containsType, BatchPair<DbQueryBatch> currentPair)
        {
            if (!DbQueryBatch.CreateNew(parametrAttribute.ConstructorArguments, containsType, out var queryBatch))
            {
                throw new Exception($"Unknown {nameof(DbQueryBatch)} constructor");
            }

            if (currentPair.Batch != null)
            {
                throw new Exception($"One attribute group cannot have more than one main attribute (batch query): '{queryBatch.MethodName}'");
            }

            currentPair.Batch = queryBatch;
        }

        private void ProcessBatchPart(AttributeData parametrAttribute, INamedTypeSymbol containsType, BatchPair<DbQueryBatch> currentPair)
        {
            if (!BatchPart.CreateNew(parametrAttribute.ConstructorArguments, out var batchPart))
            {
                throw new Exception($"Unknown {nameof(BatchPart)} constructor");
            }

            currentPair.Parts.Add(batchPart);
        }

        private void ProcessQueryRead(AttributeData queryReadAttribute, INamedTypeSymbol containsType, ReadPair<DbQuery, DbParametr> readPair)
        {
            if (!DbQuery.CreateNew(queryReadAttribute.ConstructorArguments, containsType, out var queryReadMethod))
            {
                throw new Exception($"Unknown {nameof(DbQuery)} constructor");
            }

            if (readPair.Query != null)
            {
                throw new Exception($"One attribute group cannot have more than one main attribute (query): '{readPair.Query.MethodName}'");
            }

            readPair.Query = queryReadMethod;
        }

        private void ProcessParametr(AttributeData parametrAttribute, INamedTypeSymbol containsType, ReadPair<DbQuery, DbParametr> readPair)
        {
            if (!DbParametr.CreateNew(parametrAttribute.ConstructorArguments, containsType, out var parametr, out var methodName))
            {
                throw new Exception($"Unknown {nameof(DbParametr)} constructor");
            }

            readPair.Parametrs.Add(parametr);
        }

        public override void GenerateAndSaveMethods(SourceProductionContext context, CancellationToken cancellationToken)
        {
            var readGenerator = new DbQueryGenerator();
            foreach (var queryRead in _read)
            {
                cancellationToken.ThrowIfCancellationRequested();
                readGenerator.Generate(queryRead);
                context.AddSource($"{queryRead.ContainTypeName.Name}{queryRead.MethodName}DbConnection.g.cs", readGenerator.GetCode());
            }
            _read.Clear();

            var batchReadGenerator = new DbQueryBatchGenerator();
            foreach (var batchRead in _readBatch)
            {
                cancellationToken.ThrowIfCancellationRequested();
                batchReadGenerator.Generate(batchRead);
                context.AddSource($"{batchRead.ContainTypeName.Name}{batchRead.MethodName}DbConnection.g.cs", batchReadGenerator.GetCode());
            }
            _readBatch.Clear();
        }
    }
}