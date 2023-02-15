using Gedaq.Helpers;
using Gedaq.Npgsql.Generators;
using Gedaq.Npgsql.Model;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;

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
            if (QueryReadNpgsql.IsHisConstructor(queryReadAttribute.ConstructorArguments, containsType, out var queryReadMethod))
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
                queryRead.Aliases = _queryParser.Parse(ref queryRead.Query);
                queryReadGenerator.GenerateMethod(queryRead);
                context.AddSource($"{queryRead.MethodName}Class.g.cs", queryReadGenerator.GetCode());
            }
            _readToTypeSources.Clear();
        }
    }
}