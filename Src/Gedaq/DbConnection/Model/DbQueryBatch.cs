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
            if (namedArguments.Length != 4)
            {
                return false;
            }

            var result = new DbQueryBatch();

            if (!result.MethodInfo.FillMethodName(namedArguments[0]))
            {
                return false;
            }

            if (!result.FillQueryType(namedArguments[1]))
            {
                return false;
            }

            if (!result.MethodInfo.FillMethodType(namedArguments[2]))
            {
                return false;
            }

            if (!result.MethodInfo.FillAccessModifier(namedArguments[3]))
            {
                return false;
            }

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