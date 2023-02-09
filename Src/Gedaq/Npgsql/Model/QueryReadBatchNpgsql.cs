using Gedaq.Enums;
using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace Gedaq.Npgsql.Model
{
    internal class QueryReadBatchNpgsql
    {
        public QueryMap[] Queries;
        public MethodType MethodType;
        public NpgsqlSourceType SourceType;
        public INamedTypeSymbol ContainTypeName;
        public string MethodName;

        public static bool IsHisConstructor(ImmutableArray<TypedConstant> namedArguments, INamedTypeSymbol containsType, out QueryReadBatchNpgsql method)
        {
            method = null;
            if (namedArguments.Length != 5)
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

            var methodSource = new QueryReadBatchNpgsql();
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

            if (secondArgument.Values.Length != methodSource.Queries.Length)
            {
                throw new Exception("Array lengths (types and queries) are not equal");
            }

            for (int i = 0; i < methodSource.Queries.Length; i++)
            {
                var item = secondArgument.Values[i].Value;
                var map = methodSource.Queries[i];
                if (item is ITypeSymbol typeSymbol)
                {
                    map.MapTypeName = typeSymbol;
                }
                else
                {
                    throw new Exception("Unknown type in queryTypeMap array");
                }
            }

            var thirtArgument = namedArguments[2];//MethodType
            if (thirtArgument.Kind != TypedConstantKind.Enum ||
                !(thirtArgument.Type is INamedTypeSymbol namedTypeSymbol3) ||
                !namedTypeSymbol3.IsAssignableFrom("Gedaq.Provider.Enums", "MethodType")
                )
            {
                return false;
            }

            methodSource.MethodType = (MethodType)thirtArgument.Value;

            var fourthArgument = namedArguments[3];//SourceType
            if (fourthArgument.Kind != TypedConstantKind.Enum ||
                !(fourthArgument.Type is INamedTypeSymbol namedTypeSymbol4) ||
                !namedTypeSymbol4.IsAssignableFrom("Gedaq.Npgsql.Enums", "SourceType")
                )
            {
                return false;
            }

            methodSource.SourceType = (NpgsqlSourceType)thirtArgument.Value;

            var fifthArgument = namedArguments[4];//string
            if (!(fifthArgument.Type is INamedTypeSymbol namedTypeSymbol5) ||
                namedTypeSymbol5.Name != nameof(String)
                )
            {
                return false;
            }

            methodSource.MethodName = (string)fifthArgument.Value;
            methodSource.ContainTypeName = containsType;

            method = methodSource;
            return true;
        }
    }

    internal class QueryMap
    {
        public string Query;
        public ITypeSymbol MapTypeName;
        public Aliases Aliases;
    }
}
