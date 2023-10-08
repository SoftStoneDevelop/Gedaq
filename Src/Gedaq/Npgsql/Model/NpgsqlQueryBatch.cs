using Gedaq.Base.Model;
using Gedaq.Npgsql.Enums;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace Gedaq.Npgsql.Model
{
    internal class NpgsqlQueryBatch : QueryBatchCommand
    {
        public NpgsqlSourceType SourceType;
        public BatchPart<NpgsqlQuery>[] Queries;

        internal static bool CreateNew(ImmutableArray<TypedConstant> namedArguments, INamedTypeSymbol containsType, out NpgsqlQueryBatch queryBatch)
        {
            queryBatch = null;
            if (namedArguments.Length != 7)
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
            if (!result.SetPartInterfaceType(namedArguments[5]))
            {
                return false;
            }

            if (!result.FillReturnType(namedArguments[6]))
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