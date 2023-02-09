using Gedaq.Helpers;
using Gedaq.Npgsql.Model;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace Gedaq.Npgsql
{
    internal class NpgsqlAttributeProcessor
    {
        private List<QueryReadNpgsql> _readToTypeSources = new List<QueryReadNpgsql>();
        private QueryParser _queryParser = new QueryParser();

        public bool Process(AttributeData attribute, INamedTypeSymbol containsType)
        {
            if (attribute.AttributeClass.IsAssignableFrom("Gedaq.Npgsql.Attributes", "QueryReadAttribute"))
            {
                ProcessQueryRead(attribute, containsType);
                return true;
            }

            if (attribute.AttributeClass.IsAssignableFrom("Gedaq.Npgsql.Attributes", "ScalarAttribute"))
            {
                return true;
            }

            if (attribute.AttributeClass.IsAssignableFrom("Gedaq.Npgsql.Attributes", "NonQueryAttribute"))
            {
                return true;
            }

            return false;
        }

        private void ProcessQueryRead(AttributeData queryReadAttribute, INamedTypeSymbol containsType)
        {
            if (QueryReadNpgsql.IsFirstConstructor(queryReadAttribute.ConstructorArguments, containsType, out var queryReadMethod))
            {
                _readToTypeSources.Add(queryReadMethod);
                return;
            }
        }

        public void GenerateAndSaveMethods(GeneratorExecutionContext context)
        {
            var queryReadGenerator = new QueryReadGenerator();
            foreach (var queryRead in _readToTypeSources)
            {
                for (int i = 0; i < queryRead.Queries.Length; i++)
                {
                    QueryMap query = queryRead.Queries[i];
                    query.Aliases = _queryParser.Parse(query.Query);
                }
                queryReadGenerator.GenerateMethod(queryRead);

                //TODO DO TODO
                //context.AddSource(queryReadGenerator.FileName, queryReadGenerator.GetCode());
                //context.AddSource($"AAA.g.cs", builder.ToString());
            }
        }
    }
}