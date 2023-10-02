using Gedaq.Base;
using Gedaq.Enums;
using Gedaq.Helpers;
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

                var readTemp = new ReadPair<SqlClientQuery, SqlClientParametr>();
                foreach (var attributeSyntax in attributeListSyntax.Attributes)
                {
                    cancellationToken.ThrowIfCancellationRequested();
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

                    base.ProcessAttribute(attributeData, containsType, readTemp.FormatParametrs);
                }

                TryAddReadMethod(readTemp);
            }
        }

        public override void CompleteProcessContainTypes()
        {
        }

        private void TryAddReadMethod(ReadPair<SqlClientQuery, SqlClientParametr> readPair)
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
        }

        private void ProcessQueryRead(AttributeData queryReadAttribute, INamedTypeSymbol containsType, ReadPair<SqlClientQuery, SqlClientParametr> readPair)
        {
            if (!SqlClientQuery.CreateNew(queryReadAttribute.ConstructorArguments, containsType, out var queryReadMethod))
            {
                throw new Exception($"Unknown {nameof(SqlClientQuery)} constructor");
            }

            readPair.Query = queryReadMethod;
        }

        private void ProcessParametr(AttributeData parametrAttribute, INamedTypeSymbol containsType, ReadPair<SqlClientQuery, SqlClientParametr> readPair)
        {
            if (!SqlClientParametr.CreateNew(parametrAttribute.ConstructorArguments, containsType, out var parametr, out var methodName))
            {
                throw new Exception($"Unknown {nameof(SqlClientParametr)} constructor");
            }

            readPair.Parametrs.Add(parametr);
        }

        public override void GenerateAndSaveMethods(SourceProductionContext context, CancellationToken cancellationToken)
        {
            var readGenerator = new SqlClientQueryGenerator();
            var interfaceGenerator = new InterfaceGenerator();
            foreach (var queryRead in _read)
            {
                cancellationToken.ThrowIfCancellationRequested();
                interfaceGenerator.Reset();
                readGenerator.Generate(queryRead, interfaceGenerator);
                context.AddSource($"{queryRead.ContainTypeName.Name}{queryRead.MethodName}SqlClient.g.cs", readGenerator.GetCode());
                interfaceGenerator.GenerateAndSave(
                    context,
                    queryRead.PartInterfaceType,
                    readGenerator.Usings(),
                    $"{queryRead.ContainTypeName.Name}{queryRead.MethodName}"
                    );
            }
            _read.Clear();
        }
    }
}