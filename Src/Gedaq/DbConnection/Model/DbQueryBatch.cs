using Gedaq.Base.Model;
using Gedaq.Enums;
using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace Gedaq.DbConnection.Model
{
    internal class DbQueryBatch : QueryBatchCommand
    {
        public List<(int number, DbQuery query)> Queries = new List<(int number, DbQuery query)>();

        internal static bool CreateNew(ImmutableArray<TypedConstant> namedArguments, INamedTypeSymbol containsType, out DbQueryBatch queryBatch)
        {
            queryBatch = null;
            if (namedArguments.Length != 5)
            {
                return false;
            }

            var result = new DbQueryBatch();
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