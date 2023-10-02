using Gedaq.Base.Model;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Gedaq.DbConnection.Model
{
    internal class DbQueryBatch : QueryBatchCommand
    {
        public BatchPart<DbQuery>[] Queries;

        internal static bool CreateNew(ImmutableArray<TypedConstant> namedArguments, INamedTypeSymbol containsType, out DbQueryBatch queryBatch)
        {
            queryBatch = null;
            if (namedArguments.Length != 6)
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
            if (!result.SetPartInterfaceType(namedArguments[5]))
            {
                return false;
            }

            return true;
        }

        public override IEnumerable<BatchPartBase> QueryBases()
        {
            return Queries;
        }
    }
}