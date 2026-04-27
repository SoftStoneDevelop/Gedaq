using Gedaq.Base;
using Gedaq.Base.Model;
using Gedaq.Constants;
using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.Npgsql.Generators;
using Gedaq.Npgsql.GeneratorsBatch;
using Gedaq.Npgsql.GeneratorsQuery;
using Gedaq.Npgsql.Model;
using Gedaq.Npgsql.Parser;
using Gedaq.Parser;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gedaq.Npgsql
{
    internal class NpgsqlAttributeProcessor : BaseAttributeProcessor
    {
        private readonly NpgsqlProviderInfo _providerInfo;

        private readonly List<NpgsqlQuery> _read = new List<NpgsqlQuery>();
        private readonly List<NpgsqlQueryBatch> _readBatch = new List<NpgsqlQueryBatch>();
        private readonly List<BinaryExport> _binaryExports = new List<BinaryExport>();
        private readonly List<BinaryImport> _binaryImports = new List<BinaryImport>();

        private readonly List<BatchPair<NpgsqlQueryBatch>> _batchPairTemp = new List<BatchPair<NpgsqlQueryBatch>>();
        private readonly Dictionary<string, NpgsqlQuery> _readContainsType = new Dictionary<string, NpgsqlQuery>();

        private readonly PostgreSQLQueryParser _queryParser = new PostgreSQLQueryParser();
        private readonly BinaryParser _binaryParser = new BinaryParser();

        public NpgsqlAttributeProcessor(
            SourceProductionContext context,
            NpgsqlProviderInfo providerInfo)
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
                
                var batchPair = new BatchPair<NpgsqlQueryBatch>();
                var readTemp = new ReadPair<NpgsqlQuery, NpgsqlParametr, NpgsqlDynamicParametr>();
                foreach (var attributeSyntax in attributeListSyntax.Attributes)
                {
                    _context.CancellationToken.ThrowIfCancellationRequested();
                    var attributeData = parentAttributes.First(f => f.ApplicationSyntaxReference.GetSyntax() == attributeSyntax);
                    if (attributeData.AttributeClass.IsAssignableFrom("Gedaq.Npgsql.Attributes", "QueryAttribute"))
                    {
                        ProcessQueryRead(attributeData, containsType, readTemp);
                        continue;
                    }

                    if (attributeData.AttributeClass.IsAssignableFrom("Gedaq.Npgsql.Attributes", "ParametrAttribute"))
                    {
                        ProcessParametr(attributeData, readTemp);
                        continue;
                    }

                    if (attributeData.AttributeClass.IsAssignableFrom("Gedaq.Npgsql.Attributes", "DynamicParametrAttribute"))
                    {
                        ProcessDynamicParametr(attributeData, containsType, readTemp);
                        continue;
                    }

                    if (attributeData.AttributeClass.IsAssignableFrom("Gedaq.Npgsql.Attributes", "QueryBatchAttribute"))
                    {
                        ProcessBatch(attributeData, containsType, batchPair);
                        continue;
                    }

                    if (attributeData.AttributeClass.IsAssignableFrom("Gedaq.Npgsql.Attributes", "BatchPartAttribute"))
                    {
                        ProcessBatchPart(attributeData, containsType, batchPair);
                        continue;
                    }

                    if (attributeData.AttributeClass.IsAssignableFrom("Gedaq.Npgsql.Attributes", "BinaryExportAttribute"))
                    {
                        ProcessBinaryExport(attributeData, containsType);
                        continue;
                    }

                    if (attributeData.AttributeClass.IsAssignableFrom("Gedaq.Npgsql.Attributes", "BinaryImportAttribute"))
                    {
                        ProcessBinaryImport(attributeData, containsType);
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

        private void TryAddBatchToTemp(BatchPair<NpgsqlQueryBatch> candidatePair)
        {
            if(candidatePair.IsEmpty())
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
            var set = new HashSet<int>();
            var queries = new List<BatchPart<NpgsqlQuery>>();
            foreach (var batchPair in _batchPairTemp)
            {
                set.Clear();
                queries.Clear();
                NpgsqlQuery firstRead = null;

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

                    batchPair.Batch.AllSameTypes &= CollectionHelper.SequnceEqual(firstRead.MapTypeInfos, queryRead.MapTypeInfos, SymbolEqualityComparer.Default);
                    batchPair.Batch.HaveParametrs |= queryRead.HaveParametrs();
                    batchPair.Batch.HaveFormatParametrs |= queryRead.HaveFromatParametrs();
                    batchPair.Batch.HaveDynamicParametrs |= queryRead.HaveDynamicParametrs();
                    batchPair.Batch.SourceType |= queryRead.SourceType;
                    queries.Add(new BatchPart<NpgsqlQuery>(queryRead, part.BatchNumber));
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

        private void TryAddReadMethod(ReadPair<NpgsqlQuery, NpgsqlParametr, NpgsqlDynamicParametr> readPair)
        {
            if(readPair.IsEmpty())
            {
                return;
            }

            AddDynamicParametrs(readPair);
            AddParametrs(readPair);
            AddFormatParametrs(readPair.Query, readPair.FormatParametrs);

            var query = readPair.Query;
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

            if (query.HaveDynamicParametrs() && query.HaveParametrs())
            {
                DiagnosticHelper.ReportDiagnostic(
                    _context,
                    DiagnosticConstants.AmbiguityOfParameterTypes,
                    DiagnosticConstants.AmbiguityOfParameterTypesDescr,
                    DiagnosticSeverity.Error,
                    query.MethodName);
            }

            if (query.NeedGenerate)
            {
                _read.Add(query);
            }

            _readContainsType.Add(query.MethodName, query);
        }

        private void AddDynamicParametrs(ReadPair<NpgsqlQuery, NpgsqlParametr, NpgsqlDynamicParametr> readPair)
        {
            readPair.Query.DynamicParametrs = readPair.DynamicParametr;
        }

        private void AddParametrs(ReadPair<NpgsqlQuery, NpgsqlParametr, NpgsqlDynamicParametr> readPair)
        {
            if(readPair.Parametrs.Count == 0)
            {
                return;
            }

            if(readPair.Query == null)
            {
                throw new Exception("Parameters cannot exist without a Query");
            }

            var parametrs = readPair.Parametrs.OrderBy(or => or.Position).ToList();
            readPair.Query.Parametrs = new NpgsqlParametr[parametrs.Count];

            var set = new HashSet<int>();
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

                containNamedParametr |= parametr.HaveNameInCommand;

                parametr.Index = i;
                readPair.Query.Parametrs[i] = parametr;
            }

            if (containNamedParametr && containPositionParametr)
            {
                throw new Exception("Parameters in query can be positional or named, but not combined");
            }
        }

        private void ProcessBatch(
            AttributeData parametrAttribute,
            INamedTypeSymbol containsType,
            BatchPair<NpgsqlQueryBatch> currentPair)
        {
            if (!NpgsqlQueryBatch.CreateNew(parametrAttribute.ConstructorArguments, containsType, out var queryBatch))
            {
                throw new Exception($"Unknown {nameof(NpgsqlParametr)} constructor");
            }

            if(currentPair.Batch != null)
            {
                throw new Exception($"One attribute group cannot have more than one main attribute (batch query): '{queryBatch.MethodName}'");
            }

            currentPair.Batch = queryBatch;
        }

        private void ProcessBatchPart(
            AttributeData parametrAttribute,
            INamedTypeSymbol containsType,
            BatchPair<NpgsqlQueryBatch> currentPair)
        {
            if (!BatchPart.CreateNew(parametrAttribute.ConstructorArguments, out var batchPart))
            {
                throw new Exception($"Unknown {nameof(NpgsqlParametr)} constructor");
            }

            currentPair.Parts.Add(batchPart);
        }

        private void ProcessQueryRead(
            AttributeData queryReadAttribute,
            INamedTypeSymbol containsType,
            ReadPair<NpgsqlQuery, NpgsqlParametr, NpgsqlDynamicParametr> readPair)
        {
            if (!NpgsqlQuery.CreateNew(_context, queryReadAttribute.ConstructorArguments, containsType, out var queryReadMethod))
            {
                throw new Exception($"Unknown {nameof(NpgsqlQuery)} constructor");
            }

            if(readPair.Query != null)
            {
                throw new Exception($"One attribute group cannot have more than one main attribute (query): '{readPair.Query.MethodName}'");
            }

            readPair.Query = queryReadMethod;
        }

        private void ProcessParametr(
            AttributeData parametrAttribute,
            ReadPair<NpgsqlQuery, NpgsqlParametr, NpgsqlDynamicParametr> readPair)
        {
            if (!NpgsqlParametr.CreateNew(_context, parametrAttribute.ConstructorArguments, out var parametr))
            {
                throw new Exception($"Unknown {nameof(NpgsqlParametr)} constructor");
            }

            readPair.Parametrs.Add(parametr);
        }

        private void ProcessDynamicParametr(
            AttributeData parametrAttribute,
            INamedTypeSymbol containsType,
            ReadPair<NpgsqlQuery, NpgsqlParametr, NpgsqlDynamicParametr> readPair)
        {
            if (!NpgsqlDynamicParametr.CreateNew(parametrAttribute.ConstructorArguments, containsType, out var parametr))
            {
                throw new Exception($"Unknown {nameof(NpgsqlDynamicParametr)} constructor");
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

        private void ProcessBinaryExport(AttributeData queryReadAttribute, INamedTypeSymbol containsType)
        {
            if (!BinaryExport.CreateNew(_context, queryReadAttribute.ConstructorArguments, containsType, out var binaryExport))
            {
                throw new Exception($"Unknown {nameof(BinaryExport)} constructor");
            }

            if (binaryExport.Query != null)
            {
                var aliases = _binaryParser.Parse(ref binaryExport.Query);
                binaryExport.SetAliases(binaryExport.MapTypeInfos[0], aliases);
            }
            else
            {
                for (int i = 0; i < binaryExport.MapTypeInfos.Length; i++)
                {
                    MapTypeInfo mapTypeInfo = binaryExport.MapTypeInfos[i];
                    mapTypeInfo.ParseAliasesFromType(_context, _providerInfo, binaryExport.GetAliasOverride(i));
                }
            }

            _binaryExports.Add(binaryExport);
        }

        private void ProcessBinaryImport(AttributeData queryReadAttribute, INamedTypeSymbol containsType)
        {
            if (!BinaryImport.CreateNew(_context, queryReadAttribute.ConstructorArguments, containsType, out var binaryImport))
            {
                throw new Exception($"Unknown {nameof(BinaryExport)} constructor");
            }

            var aliases = _binaryParser.Parse(ref binaryImport.Query);
            binaryImport.SetAliases(aliases);
            _binaryImports.Add(binaryImport);
        }

        public override void GenerateAndSaveMethods()
        {
            var interfaceGenerator = new InterfaceGenerator();
            var readGenerator = new NpgsqlQueryGenerator(_context, _providerInfo);
            foreach (var queryRead in _read)
            {
                _context.CancellationToken.ThrowIfCancellationRequested();
                interfaceGenerator.Reset();
                readGenerator.GenerateMethod(queryRead, interfaceGenerator);
                _context.AddSource($"{queryRead.ContainTypeName.Name}{queryRead.MethodName}Npgsql.g.cs", readGenerator.GetCode());
                interfaceGenerator.GenerateAndSave(
                    _context,
                    queryRead.PartInterfaceType,
                    readGenerator.Usings(),
                    $"{queryRead.ContainTypeName.Name}{queryRead.MethodName}");
            }
            _read.Clear();

            var batchReadGenerator = new NpgsqlQueryBatchGenerator(_context, _providerInfo);
            foreach (var batchRead in _readBatch)
            {
                _context.CancellationToken.ThrowIfCancellationRequested();
                interfaceGenerator.Reset();
                batchReadGenerator.GenerateMethod(batchRead, interfaceGenerator);
                _context.AddSource($"{batchRead.ContainTypeName.Name}{batchRead.MethodName}Npgsql.g.cs", batchReadGenerator.GetCode());
                interfaceGenerator.GenerateAndSave(
                    _context,
                    batchRead.PartInterfaceType,
                    readGenerator.Usings(),
                    $"{batchRead.ContainTypeName.Name}{batchRead.MethodName}");
            }
            _readBatch.Clear();

            var binaryExportGenerator = new BinaryExportGenerator(_context);
            foreach (var binaryExport in _binaryExports)
            {
                _context.CancellationToken.ThrowIfCancellationRequested();
                interfaceGenerator.Reset();
                binaryExportGenerator.Generate(binaryExport, interfaceGenerator);
                _context.AddSource($"{binaryExport.ContainTypeName.Name}{binaryExport.MethodName}Npgsql.g.cs", binaryExportGenerator.GetCode());
                interfaceGenerator.GenerateAndSave(
                    _context,
                    binaryExport.PartInterfaceType,
                    readGenerator.Usings(),
                    $"{binaryExport.ContainTypeName.Name}{binaryExport.MethodName}");
            }
            _binaryExports.Clear();

            var binaryImportGenerator = new BinaryImportGenerator(_context);
            foreach (var binaryImport in _binaryImports)
            {
                _context.CancellationToken.ThrowIfCancellationRequested();
                interfaceGenerator.Reset();
                binaryImportGenerator.Generate(binaryImport, interfaceGenerator);
                _context.AddSource($"{binaryImport.ContainTypeName.Name}{binaryImport.MethodName}Npgsql.g.cs", binaryImportGenerator.GetCode());
                interfaceGenerator.GenerateAndSave(
                    _context,
                    binaryImport.PartInterfaceType,
                    readGenerator.Usings(),
                    $"{binaryImport.ContainTypeName.Name}{binaryImport.MethodName}");
            }
            _binaryImports.Clear();
        }
    }
}