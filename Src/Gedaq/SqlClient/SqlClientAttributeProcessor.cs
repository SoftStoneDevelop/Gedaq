using Gedaq.Base;
using Gedaq.Constants;
using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.Npgsql.Model;
using Gedaq.Parser;
using Gedaq.SqlClient.GeneratorsQuery;
using Gedaq.SqlClient.Model;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Gedaq.SqlClient
{
    internal class SqlClientAttributeProcessor : BaseAttributeProcessor
    {
        private List<SqlClientQuery> _read = new List<SqlClientQuery>();
        private QueryParser _queryParser = new QueryParser();

        public SqlClientAttributeProcessor(SourceProductionContext context)
            : base(context)
        {
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

                var readTemp = new ReadPair<SqlClientQuery, SqlClientParametr, SqlClientDynamicParametr>();
                foreach (var attributeSyntax in attributeListSyntax.Attributes)
                {
                    _context.CancellationToken.ThrowIfCancellationRequested();
                    var attributeData = parentAttributes.First(f => f.ApplicationSyntaxReference.GetSyntax() == attributeSyntax);
                    if (attributeData.AttributeClass.IsAssignableFrom("Gedaq.SqlClient.Attributes", "QueryAttribute"))
                    {
                        ProcessQueryRead(attributeData, containsType, readTemp);
                        continue;
                    }

                    if (attributeData.AttributeClass.IsAssignableFrom("Gedaq.SqlClient.Attributes", "ParametrAttribute"))
                    {
                        ProcessParametr(attributeData, containsType, readTemp);
                        continue;
                    }

                    if (attributeData.AttributeClass.IsAssignableFrom("Gedaq.SqlClient.Attributes", "DynamicParametrAttribute"))
                    {
                        ProcessDynamicParametr(attributeData, containsType, readTemp);
                        continue;
                    }

                    base.ProcessAttribute(attributeData, containsType, readTemp.FormatParametrs);
                }

                TryAddReadMethod(readTemp);
            }
        }

        public override void CompleteProcessContainTypes()
        {
        }

        private void TryAddReadMethod(ReadPair<SqlClientQuery, SqlClientParametr, SqlClientDynamicParametr> readPair)
        {
            if (readPair.IsEmpty())
            {
                return;
            }

            var query = readPair.Query;
            readPair.Query.Parametrs = readPair.Parametrs.ToArray();
            for (int i = 0; i < query.Parametrs.Length; i++)
            {
                query.Parametrs[i].Index = i;
            }

            AddDynamicParametrs(readPair);
            AddFormatParametrs(readPair.Query, readPair.FormatParametrs);

            if (query.QueryType == QueryType.NonQuery)
            {
                query.IsRowsAffected = true;
            }
            else
            {
                query.MapTypeInfos[0].Aliases = _queryParser.Parse(ref query.Query, out _);
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
        }

        private void AddDynamicParametrs(ReadPair<SqlClientQuery, SqlClientParametr, SqlClientDynamicParametr> readPair)
        {
            readPair.Query.DynamicParametrs = readPair.DynamicParametr;
        }

        private void ProcessQueryRead(
            AttributeData queryReadAttribute,
            INamedTypeSymbol containsType,
            ReadPair<SqlClientQuery, SqlClientParametr, SqlClientDynamicParametr> readPair)
        {
            if (!SqlClientQuery.CreateNew(_context, queryReadAttribute.ConstructorArguments, containsType, out var queryReadMethod))
            {
                throw new Exception($"Unknown {nameof(SqlClientQuery)} constructor");
            }

            readPair.Query = queryReadMethod;
        }

        private void ProcessParametr(
            AttributeData parametrAttribute,
            INamedTypeSymbol containsType,
            ReadPair<SqlClientQuery, SqlClientParametr, SqlClientDynamicParametr> readPair)
        {
            if (!SqlClientParametr.CreateNew(parametrAttribute.ConstructorArguments, containsType, out var parametr, out var methodName))
            {
                throw new Exception($"Unknown {nameof(SqlClientParametr)} constructor");
            }

            readPair.Parametrs.Add(parametr);
        }

        private void ProcessDynamicParametr(
            AttributeData parametrAttribute,
            INamedTypeSymbol containsType,
            ReadPair<SqlClientQuery, SqlClientParametr, SqlClientDynamicParametr> readPair)
        {
            if (!SqlClientDynamicParametr.CreateNew(parametrAttribute.ConstructorArguments, containsType, out var parametr))
            {
                throw new Exception($"Unknown {nameof(SqlClientDynamicParametr)} constructor");
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
            var readGenerator = new SqlClientQueryGenerator(_context);
            var interfaceGenerator = new InterfaceGenerator();
            foreach (var queryRead in _read)
            {
                _context.CancellationToken.ThrowIfCancellationRequested();
                interfaceGenerator.Reset();
                readGenerator.Generate(queryRead, interfaceGenerator);
                _context.AddSource($"{queryRead.ContainTypeName.Name}{queryRead.MethodName}SqlClient.g.cs", readGenerator.GetCode());
                interfaceGenerator.GenerateAndSave(
                    _context,
                    queryRead.PartInterfaceType,
                    readGenerator.Usings(),
                    $"{queryRead.ContainTypeName.Name}{queryRead.MethodName}");
            }
            _read.Clear();
        }
    }
}