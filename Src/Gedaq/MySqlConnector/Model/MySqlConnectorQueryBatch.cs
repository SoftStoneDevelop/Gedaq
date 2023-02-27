using Gedaq.Base.Model;
using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.MySqlConnector.Enums;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Gedaq.MySqlConnector.Model
{
    internal class MySqlConnectorQueryBatch : QueryBatch
    {
        public MySqlConnectorSourceType SourceType;
        public List<(int number, MySqlConnectorQuery query)> Queries = new List<(int number, MySqlConnectorQuery query)>();

        internal static bool CreateNew(ImmutableArray<TypedConstant> namedArguments, INamedTypeSymbol containsType, out MySqlConnectorQueryBatch queryBatch)
        {
            queryBatch = null;
            if (namedArguments.Length != 3)
            {
                return false;
            }

            var result = new MySqlConnectorQueryBatch();
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

        public override IEnumerable<(int, QueryBase)> QueryBases()
        {
            return Queries.Select(sel => (sel.number, (QueryBase)sel.query));
        }
    }
}