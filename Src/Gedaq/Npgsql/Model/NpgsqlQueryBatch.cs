using Gedaq.Base.Model;
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
    internal class NpgsqlQueryBatch : QueryBatchCommand
    {
        public NpgsqlSourceType SourceType;
        public List<(int number, NpgsqlQuery query)> Queries = new List<(int number, NpgsqlQuery query)>();

        internal static bool CreateNew(ImmutableArray<TypedConstant> namedArguments, INamedTypeSymbol containsType, out NpgsqlQueryBatch queryBatch)
        {
            queryBatch = null;
            if (namedArguments.Length != 5)
            {
                return false;
            }

            var result = new NpgsqlQueryBatch();
            if (!result.FillQueryType(namedArguments[1]))
            {
                return false;
            }

            result.MethodInfo =
                new BaseMethodInfo(
                    namedArguments[0],
                    namedArguments[2],
                    namedArguments[3],
                    namedArguments[4],
                    containsType
                    );

            result.ContainTypeName = containsType;

            queryBatch = result;
            return true;
        }

        public override IEnumerable<(int, QueryBaseCommand)> QueryBases()
        {
            return Queries.Select(sel => (sel.number, (QueryBaseCommand)sel.query));
        }
    }
}