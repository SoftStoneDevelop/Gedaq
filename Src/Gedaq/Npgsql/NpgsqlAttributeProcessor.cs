using Gedaq.Base;
using Gedaq.Base.Model;
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
        private class BatchPair
        {
            public NpgsqlQueryBatch Batch { get; set; }
            public List<BatchPart> Parts { get; } = new List<BatchPart>();

            public bool IsEmpty()
            {
                return Batch == null && Parts.Count == 0;
            }
        }

        private class ReadPair
        {
            public NpgsqlQuery Query { get; set; }
            public List<NpgsqlParametr> Parametrs { get; } = new List<NpgsqlParametr>();

            public List<FormatParametr> FormatParametrs { get; } = new List<FormatParametr>();

            public bool IsEmpty()
            {
                return Query == null && Parametrs.Count == 0;
            }
        }

        private List<NpgsqlQuery> _read = new List<NpgsqlQuery>();
        private List<NpgsqlQueryBatch> _readBatch = new List<NpgsqlQueryBatch>();
        private List<BinaryExport> _binaryExports = new List<BinaryExport>();
        private List<BinaryImport> _binaryImports = new List<BinaryImport>();

        private List<BatchPair> _batchPairTemp = new List<BatchPair>();
        private Dictionary<string, NpgsqlQuery> _readContainsType = new Dictionary<string, NpgsqlQuery>();

        private PostgreSQLQueryParser _queryParser = new PostgreSQLQueryParser();
        private BinaryParser _binaryParser = new BinaryParser();

        public override void ProcessAttributes(SyntaxList<AttributeListSyntax> attributes, Compilation compilation, INamedTypeSymbol containsType)
        {
            foreach (var attributeListSyntax in attributes)
            {
                var parentSymbol = attributeListSyntax.Parent.GetDeclaredSymbol(compilation);
                var parentAttributes = parentSymbol.GetAttributes();
                
                var batchPair = new BatchPair();
                var readTemp = new ReadPair();
                foreach (var attributeSyntax in attributeListSyntax.Attributes)
                {
                    var attributeData = parentAttributes.First(f => f.ApplicationSyntaxReference.GetSyntax() == attributeSyntax);
                    if (attributeData.AttributeClass.IsAssignableFrom("Gedaq.Npgsql.Attributes", "QueryAttribute"))
                    {
                        ProcessQueryRead(attributeData, containsType, readTemp);
                        continue;
                    }

                    if (attributeData.AttributeClass.IsAssignableFrom("Gedaq.Npgsql.Attributes", "ParametrAttribute"))
                    {
                        ProcessParametr(attributeData, containsType, readTemp);
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

        private void TryAddBatchToTemp(BatchPair candidatePair)
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
            foreach (var batchPair in _batchPairTemp)
            {
                NpgsqlQuery firstRead = null;

                var set = new HashSet<int>();
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
                    batchPair.Batch.SourceType |= queryRead.SourceType;
                    batchPair.Batch.Queries.Add((part.BatchNumber, queryRead));
                }

                _readBatch.Add(batchPair.Batch);
            }

            _batchPairTemp.Clear();
            _readContainsType.Clear();
        }

        private void TryAddReadMethod(ReadPair readPair)
        {
            if(readPair.IsEmpty())
            {
                return;
            }

            var query = readPair.Query;
            AddParametrs(readPair);
            AddFormatParametrs(readPair.Query, readPair.FormatParametrs);

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

        private void AddParametrs(ReadPair readPair)
        {
            if(readPair.Parametrs.Count == 0)
            {
                return;
            }

            if(readPair.Query == null)
            {
                throw new Exception("Parameters cannot exist without a Query");
            }

            var set = new HashSet<int>();
            var parametrs = readPair.Parametrs.OrderBy(or => or.Position).ToList();
            readPair.Query.Parametrs = new NpgsqlParametr[parametrs.Count];

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

                containNamedParametr |= parametr.HaveNameInCommand;

                readPair.Query.Parametrs[i] = parametr;
            }

            if (containNamedParametr && containPositionParametr)
            {
                throw new Exception("Parameters in query can be positional or named, but not combined");
            }
        }

        private void ProcessBatch(AttributeData parametrAttribute, INamedTypeSymbol containsType, BatchPair currentPair)
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

        private void ProcessBatchPart(AttributeData parametrAttribute, INamedTypeSymbol containsType, BatchPair currentPair)
        {
            if (!BatchPart.CreateNew(parametrAttribute.ConstructorArguments, out var batchPart))
            {
                throw new Exception($"Unknown {nameof(NpgsqlParametr)} constructor");
            }

            currentPair.Parts.Add(batchPart);
        }

        private void ProcessQueryRead(AttributeData queryReadAttribute, INamedTypeSymbol containsType, ReadPair readPair)
        {
            if (!NpgsqlQuery.CreateNew(queryReadAttribute.ConstructorArguments, containsType, out var queryReadMethod))
            {
                throw new Exception($"Unknown {nameof(NpgsqlQuery)} constructor");
            }

            if(readPair.Query != null)
            {
                throw new Exception($"One attribute group cannot have more than one main attribute (query): '{readPair.Query.MethodName}'");
            }

            readPair.Query = queryReadMethod;
        }

        private void ProcessParametr(AttributeData parametrAttribute, INamedTypeSymbol containsType, ReadPair readPair)
        {
            if (!NpgsqlParametr.CreateNew(parametrAttribute.ConstructorArguments, containsType, out var parametr, out var methodName))
            {
                throw new Exception($"Unknown {nameof(NpgsqlParametr)} constructor");
            }

            readPair.Parametrs.Add(parametr);
        }

        private void ProcessBinaryExport(AttributeData queryReadAttribute, INamedTypeSymbol containsType)
        {
            if (!BinaryExport.CreateNew(queryReadAttribute.ConstructorArguments, containsType, out var binaryExport))
            {
                throw new Exception($"Unknown {nameof(BinaryExport)} constructor");
            }

            var aliases = _binaryParser.Parse(ref binaryExport.Query);
            binaryExport.SetAliases(aliases);
            _binaryExports.Add(binaryExport);
        }

        private void ProcessBinaryImport(AttributeData queryReadAttribute, INamedTypeSymbol containsType)
        {
            if (!BinaryImport.CreateNew(queryReadAttribute.ConstructorArguments, containsType, out var binaryImport))
            {
                throw new Exception($"Unknown {nameof(BinaryExport)} constructor");
            }

            var aliases = _binaryParser.Parse(ref binaryImport.Query);
            binaryImport.SetAliases(aliases);
            _binaryImports.Add(binaryImport);
        }

        public override void GenerateAndSaveMethods(SourceProductionContext context)
        {
            var readGenerator = new NpgsqlQueryGenerator();
            foreach (var queryRead in _read)
            {
                readGenerator.GenerateMethod(queryRead);
                context.AddSource($"{queryRead.ContainTypeName.Name}{queryRead.MethodName}Npgsql.g.cs", readGenerator.GetCode());
            }
            _read.Clear();

            var batchReadGenerator = new NpgsqlQueryBatchGenerator();
            foreach (var batchRead in _readBatch)
            {
                batchReadGenerator.GenerateMethod(batchRead);
                context.AddSource($"{batchRead.ContainTypeName.Name}{batchRead.MethodName}Npgsql.g.cs", batchReadGenerator.GetCode());
            }
            _readBatch.Clear();

            var binaryExportGenerator = new BinaryExportGenerator();
            foreach (var binaryExport in _binaryExports)
            {
                binaryExportGenerator.Generate(binaryExport);
                context.AddSource($"{binaryExport.ContainTypeName.Name}{binaryExport.MethodName}Npgsql.g.cs", binaryExportGenerator.GetCode());
            }
            _binaryExports.Clear();

            var binaryImportGenerator = new BinaryImportGenerator();
            foreach (var binaryImport in _binaryImports)
            {
                binaryImportGenerator.Generate(binaryImport);
                context.AddSource($"{binaryImport.ContainTypeName.Name}{binaryImport.MethodName}Npgsql.g.cs", binaryImportGenerator.GetCode());
            }
            _binaryImports.Clear();
        }
    }
}