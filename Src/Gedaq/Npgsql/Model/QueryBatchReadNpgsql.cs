using Gedaq.DbConnection.Model;
using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.Npgsql.Enums;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Gedaq.Npgsql.Model
{
    internal class QueryBatchReadNpgsql : BaseGenerateItem
    {
        public NpgsqlSourceType SourceType;
        public List<(int number, QueryReadNpgsql query)> Queries = new List<(int number, QueryReadNpgsql query)>();
        public bool AllSameTypes = true;
        public bool HaveParametrs;

        internal static bool CreateNew(ImmutableArray<TypedConstant> namedArguments, INamedTypeSymbol containsType, out QueryBatchReadNpgsql queryBatch)
        {
            queryBatch = null;
            if (namedArguments.Length != 3)
            {
                return false;
            }

            var result = new QueryBatchReadNpgsql();
            if (!(namedArguments[0].Type is INamedTypeSymbol methodName) ||
                methodName.Name != nameof(String)
                )
            {
                return false;
            }

            result.MethodName = (string)namedArguments[0].Value;

            if (namedArguments[1].Kind != TypedConstantKind.Enum ||
                !(namedArguments[1].Type is INamedTypeSymbol queryType) ||
                !queryType.IsAssignableFrom("Gedaq.Common.Enums", "QueryType")
                )
            {
                return false;
            }

            result.QueryType = (QueryType)namedArguments[1].Value;

            if (namedArguments[2].Kind != TypedConstantKind.Enum ||
                !(namedArguments[2].Type is INamedTypeSymbol methodType) ||
                !methodType.IsAssignableFrom("Gedaq.Common.Enums", "MethodType")
                )
            {
                return false;
            }

            result.MethodType = (MethodType)namedArguments[2].Value;
            result.ContainTypeName = containsType;

            queryBatch = result;
            return true;
        }
    }
}