using Gedaq.DbConnection.Model;
using Gedaq.Enums;
using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace Gedaq.DbConnection
{
    internal class DbQueryBatch : QueryBatch
    {
        public List<(int number, DbQuery query)> Queries = new List<(int number, DbQuery query)>();

        internal static bool CreateNew(ImmutableArray<TypedConstant> namedArguments, INamedTypeSymbol containsType, out DbQueryBatch queryBatch)
        {
            queryBatch = null;
            if (namedArguments.Length != 3)
            {
                return false;
            }

            var result = new DbQueryBatch();
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