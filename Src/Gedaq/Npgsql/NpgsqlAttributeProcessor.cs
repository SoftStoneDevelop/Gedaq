using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.Npgsql.Generators;
using Gedaq.Npgsql.Model;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Reflection;
using System.Text;

namespace Gedaq.Npgsql
{
    internal class NpgsqlAttributeProcessor
    {
        private List<QueryReadNpgsql> _readToTypeSources = new List<QueryReadNpgsql>();
        private List<QueryReadBatchNpgsql> _readBatchToTypeSources = new List<QueryReadBatchNpgsql>();

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

            if (QueryReadBatchNpgsql.IsHisConstructor(queryReadAttribute.ConstructorArguments, containsType, out var queryReadBatchMethod))
            {
                _readBatchToTypeSources.Add(queryReadBatchMethod);
                return;
            }
        }

        public void GenerateAndSaveMethods(GeneratorExecutionContext context)
        {
            var queryReadBatchGenerator = new QueryReadBatchGenerator();
            foreach (var queryRead in _readBatchToTypeSources)
            {
                if(queryRead.Queries.Length == 1)
                {
                    var readSource = new QueryReadNpgsql(queryRead);
                    _readToTypeSources.Add(readSource);
                    continue;
                }

                for (int i = 0; i < queryRead.Queries.Length; i++)
                {
                    QueryMap query = queryRead.Queries[i];
                    query.Aliases = _queryParser.Parse(ref query.Query);
                }

                if (queryRead.MethodType.HasFlag(Enums.MethodType.Sync))
                {
                    queryReadBatchGenerator.GenerateMethod(queryRead);
                    context.AddSource($"{queryRead.MethodName}{queryRead.SourceType.ToString()}.g.cs", queryReadBatchGenerator.GetCode());
                }

                if (queryRead.MethodType.HasFlag(Enums.MethodType.Async))
                {
                    queryReadBatchGenerator.GenerateMethod(queryRead);
                    context.AddSource($"{queryRead.MethodName}{queryRead.SourceType.ToString()}Async.g.cs", queryReadBatchGenerator.GetCode());
                }
            }
            _readBatchToTypeSources.Clear();

            var queryReadGenerator = new QueryReadGenerator();
            foreach (var queryRead in _readToTypeSources)
            {
                queryRead.Aliases = _queryParser.Parse(ref queryRead.Query);

                if(queryRead.MethodType.HasFlag(Enums.MethodType.Sync))
                {
                    queryReadGenerator.GenerateMethod(queryRead);
                    context.AddSource($"{queryRead.MethodName}{queryRead.SourceType.ToString()}.g.cs", queryReadGenerator.GetCode());
                }

                if (queryRead.MethodType.HasFlag(Enums.MethodType.Async))
                {
                    queryReadGenerator.GenerateAsyncMethod(queryRead);
                    context.AddSource($"{queryRead.MethodName}{queryRead.SourceType.ToString()}Async.g.cs", queryReadGenerator.GetCode());
                }
            }
            _readToTypeSources.Clear();
        }
    }
}