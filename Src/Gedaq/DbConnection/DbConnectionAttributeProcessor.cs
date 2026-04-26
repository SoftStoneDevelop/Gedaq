using Gedaq.Base;
using Gedaq.Base.Model;
using Gedaq.Constants;
using Gedaq.DbConnection;
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

namespace Gedaq.Npgsql
{
    internal class DbConnectionAttributeProcessor : BaseAttributeProcessor
    {
        private readonly DbProviderInfo _providerInfo;

        private readonly List<DbQuery> _read = new List<DbQuery>();
        private readonly List<DbQueryBatch> _readBatch = new List<DbQueryBatch>();

        private readonly List<BatchPair<DbQueryBatch>> _batchPairTemp = new List<BatchPair<DbQueryBatch>>();
        private readonly Dictionary<string, DbQuery> _readContainsType = new Dictionary<string, DbQuery>();

        private readonly QueryParser _queryParser = new QueryParser();

        public DbConnectionAttributeProcessor(
            SourceProductionContext context,
            DbProviderInfo providerInfo)
            : base(context)
        {
            _providerInfo = providerInfo;
        }

        public override void ProcessAttributes(
            SyntaxList<AttributeListSyntax> attributes, 
            Compilation compilation, 
            INamedTypeSymbol containsType)
        {
            foreach (var attributeListSyntax in attributes)
            {
                _context.CancellationToken.ThrowIfCancellationRequested();
                var parentSymbol = attributeListSyntax.Parent.GetDeclaredSymbol(compilation);
                var parentAttributes = parentSymbol.GetAttributes();

                var batchPair = new BatchPair<DbQueryBatch>();
                var readTemp = new ReadPair<DbQuery, DbParametr, DbDynamicParametr>();
                foreach (var attributeSyntax in attributeListSyntax.Attributes)
                {
                    _context.CancellationToken.ThrowIfCancellationRequested();
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

                    if (attributeData.AttributeClass.IsAssignableFrom("Gedaq.DbConnection.Attributes", "DynamicParametrAttribute"))
                    {
                        ProcessDynamicParametr(attributeData, containsType, readTemp);
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
                DiagnosticHelper.ReportDiagnostic(
                    _context,
                    DiagnosticConstants.BatchMustContainParts,
                    $"Batch query must contain batch parts:'{candidatePair.Batch.MethodName}'",
                    DiagnosticSeverity.Error);
                return;
            }

            if (candidatePair.Batch == null)
            {
                DiagnosticHelper.ReportDiagnostic(
                    _context,
                    DiagnosticConstants.BatchMustContainParts,
                    $"Batch query must contain batch parts:'{candidatePair.Batch.MethodName}'",
                    DiagnosticSeverity.Error);
                return;
            }

            _batchPairTemp.Add(candidatePair);
        }

        private void FillBatches()
        {
            var set = new HashSet<int>();
            var queries = new List<BatchPart<DbQuery>>();
            foreach (var batchPair in _batchPairTemp)
            {
                set.Clear();
                queries.Clear();
                DbQuery firstRead = null;

                foreach (var part in batchPair.Parts.OrderBy(or => or.BatchNumber))
                {
                    if (!set.Add(part.BatchNumber))
                    {
                        DiagnosticHelper.ReportDiagnostic(
                            _context,
                            DiagnosticConstants.BatchNumberUnique,
                            $"Batch number must be unique in batch:'{batchPair.Batch.MethodName}'",
                            DiagnosticSeverity.Error);
                    }

                    if(!_readContainsType.TryGetValue(part.MethodName, out var queryRead))
                    {
                        throw new Exception($"Request for batch not found:'{part.MethodName}'");
                    }

                    if(firstRead == null)
                    {
                        firstRead = queryRead;
                    }

                    batchPair.Batch.AllSameTypes &= CollectionHelper.SequnceEqual(firstRead.MapTypeInfos, queryRead.MapTypeInfos, SymbolEqualityComparer.Default);
                    batchPair.Batch.HaveParametrs |= queryRead.HaveParametrs();
                    batchPair.Batch.HaveFormatParametrs |= queryRead.HaveFromatParametrs();
                    batchPair.Batch.HaveDynamicParametrs |= queryRead.HaveDynamicParametrs();
                    queries.Add(new BatchPart<DbQuery>(queryRead, part.BatchNumber));
                }

                if (batchPair.Batch.HaveParametrs && batchPair.Batch.HaveDynamicParametrs)
                {
                    DiagnosticHelper.ReportDiagnostic(
                        _context,
                        DiagnosticConstants.AmbiguityOfParameterTypes,
                        DiagnosticConstants.AmbiguityOfParameterTypesDescr,
                        DiagnosticSeverity.Error,
                        batchPair.Batch.MethodName);
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

        private void TryAddReadMethod(ReadPair<DbQuery, DbParametr, DbDynamicParametr> readPair)
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

            AddDynamicParametrs(readPair);
            AddFormatParametrs(query, readPair.FormatParametrs);

            if (query.QueryType == QueryType.NonQuery)
            {
                query.IsRowsAffected = true;
            }
            else
            {
                if (!query.IsDynamicQuery())
                {
                    // query must contain select or return
                    query.MapTypeInfos[0].Aliases = _queryParser.Parse(ref query.Query, out _);
                }
                else
                {
                    for (int i = 0; i < query.MapTypeInfos.Length; i++)
                    {
                        MapTypeInfo mapTypeInfo = query.MapTypeInfos[i];
                        mapTypeInfo.ParseAliasesFromType(_context, _providerInfo, query.GetAliasOverride(i));
                    }
                }
            }

            if (query.NeedGenerate)
            {
                _read.Add(query);
            }

            _readContainsType.Add(query.MethodName, query);
        }

        private void AddDynamicParametrs(ReadPair<DbQuery, DbParametr, DbDynamicParametr> readPair)
        {
            readPair.Query.DynamicParametrs = readPair.DynamicParametr;
        }

        private void ProcessBatch(
            AttributeData parametrAttribute,
            INamedTypeSymbol containsType,
            BatchPair<DbQueryBatch> currentPair)
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

        private void ProcessBatchPart(
            AttributeData parametrAttribute,
            INamedTypeSymbol containsType,
            BatchPair<DbQueryBatch> currentPair)
        {
            if (!BatchPart.CreateNew(parametrAttribute.ConstructorArguments, out var batchPart))
            {
                throw new Exception($"Unknown {nameof(BatchPart)} constructor");
            }

            currentPair.Parts.Add(batchPart);
        }

        private void ProcessQueryRead(
            AttributeData queryReadAttribute,
            INamedTypeSymbol containsType,
            ReadPair<DbQuery, DbParametr, DbDynamicParametr> readPair)
        {
            if (!DbQuery.CreateNew(_context, queryReadAttribute.ConstructorArguments, containsType, out var queryReadMethod))
            {
                throw new Exception($"Unknown {nameof(DbQuery)} constructor");
            }

            if (readPair.Query != null)
            {
                throw new Exception($"One attribute group cannot have more than one main attribute (query): '{readPair.Query.MethodName}'");
            }

            readPair.Query = queryReadMethod;
        }

        private void ProcessParametr(
            AttributeData parametrAttribute,
            INamedTypeSymbol containsType,
            ReadPair<DbQuery, DbParametr, DbDynamicParametr> readPair)
        {
            if (!DbParametr.CreateNew(parametrAttribute.ConstructorArguments, containsType, out var parametr))
            {
                throw new Exception($"Unknown {nameof(DbParametr)} constructor");
            }

            readPair.Parametrs.Add(parametr);
        }

        private void ProcessDynamicParametr(
            AttributeData parametrAttribute,
            INamedTypeSymbol containsType,
            ReadPair<DbQuery, DbParametr, DbDynamicParametr> readPair)
        {
            if (!DbDynamicParametr.CreateNew(parametrAttribute.ConstructorArguments, containsType, out var parametr))
            {
                throw new Exception($"Unknown {nameof(DbDynamicParametr)} constructor");
            }

            if (readPair.DynamicParametr != null)
            {
                DiagnosticHelper.ReportDiagnostic(
                    _context,
                    DiagnosticConstants.DynamicParameterDuplicate,
                    DiagnosticConstants.DynamicParameterDuplicateDescr,
                    DiagnosticSeverity.Error);
            }

            readPair.DynamicParametr = parametr;
        }

        public override void GenerateAndSaveMethods()
        {
            var readGenerator = new DbQueryGenerator(_context, _providerInfo);
            var interfaceGenerator = new InterfaceGenerator();
            foreach (var queryRead in _read)
            {
                _context.CancellationToken.ThrowIfCancellationRequested();
                interfaceGenerator.Reset();
                readGenerator.Generate(queryRead, interfaceGenerator);

                _context.AddSource($"{queryRead.ContainTypeName.Name}{queryRead.MethodName}DbConnection.g.cs", readGenerator.GetCode());
                interfaceGenerator.GenerateAndSave(
                    _context, 
                    queryRead.PartInterfaceType, 
                    readGenerator.Usings(), 
                    $"{queryRead.ContainTypeName.Name}{queryRead.MethodName}");
            }
            _read.Clear();

            var batchReadGenerator = new DbQueryBatchGenerator(_context, _providerInfo);
            foreach (var batchRead in _readBatch)
            {
                _context.CancellationToken.ThrowIfCancellationRequested();
                interfaceGenerator.Reset();
                batchReadGenerator.Generate(batchRead, interfaceGenerator);
                _context.AddSource($"{batchRead.ContainTypeName.Name}{batchRead.MethodName}DbConnection.g.cs", batchReadGenerator.GetCode());
                interfaceGenerator.GenerateAndSave(
                    _context,
                    batchRead.PartInterfaceType,
                    readGenerator.Usings(),
                    $"{batchRead.ContainTypeName.Name}{batchRead.MethodName}");
            }
            _readBatch.Clear();
        }
    }
}