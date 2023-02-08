using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace Gedaq
{
    internal class AttributeProcessor
    {
        private NpgsqlAttributeProcessor _npgsqlProcessor = new NpgsqlAttributeProcessor();

        public void TryFillFrom(INamedTypeSymbol type)
        {
            var attributes = type.GetAttributes();
            foreach (var attribute in attributes)
            {
                if(_npgsqlProcessor.Process(in attribute))
                {
                    continue;
                }

                //another databases(include processor for common database IConnection source)
            }
        }
    }

    internal class NpgsqlAttributeProcessor
    {
        private List<QueryReadNpgsql> _readToTypeSources = new List<QueryReadNpgsql>();

        public bool Process(in AttributeData attribute)
        {
            if (attribute.AttributeClass.IsAssignableFrom("Gedaq.Npgsql.Attributes", "QueryReadAttribute"))
            {
                ProcessQueryRead(in attribute);
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

        private void ProcessQueryRead(in AttributeData queryReadAttribute)
        {
            var methodSource = new QueryReadNpgsql();
            if(IsFirstConstructor(queryReadAttribute.ConstructorArguments))
            {
                return;
            }
        }

        private bool IsFirstConstructor(ImmutableArray<TypedConstant> namedArguments)
        {
            if(namedArguments.Length != 4)
            {
                return false;
            }

            var firstArgument = namedArguments[0];//Type[]
            if (!(firstArgument.Type is IArrayTypeSymbol strArray) ||
                strArray.ElementType.Name != nameof(String) ||
                strArray.Rank != 1
                )
            {
                return false;
            }

            var methodSource = new QueryReadNpgsql();
            methodSource.Queries = new QueryMap[firstArgument.Values.Length];
            for (int i = 0; i < methodSource.Queries.Length; i++)
            {
                var item = firstArgument.Values[i];
                var query = (string)item.Value;

                var map = new QueryMap();
                map.Query = query;
                methodSource.Queries[i] = map;
            }

            var secondArgument = namedArguments[1];//Type[]
            if (!(secondArgument.Type is IArrayTypeSymbol typeArray) ||
                typeArray.ElementType.Name != nameof(Type) ||
                typeArray.Rank != 1
                )
            {
                return false;
            }

            if(secondArgument.Values.Length != methodSource.Queries.Length)
            {
                throw new Exception("Array lengths (types and queries) are not equal");
            }

            for (int i = 0; i < methodSource.Queries.Length; i++)
            {
                var item = secondArgument.Values[i].Value;
                var map = methodSource.Queries[i];
                if (item is INamedTypeSymbol namedTypeSymbol)
                {
                    map.MapTypeName = namedTypeSymbol;
                }
                else
                {
                    throw new Exception("Unknown type in queryTypeMap array");
                }
            }

            var thirtArgument = namedArguments[2];//MethodType
            var fourthArgument = namedArguments[3];//SourceType

            _readToTypeSources.Add(methodSource);
            return true;
        }
    }
}