using Gedaq.Base.Model;
using Gedaq.Enums;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Gedaq.SqlClient.Model
{
    internal class SqlClientQuery : QueryBaseCommand
    {
        public SqlClientParametr[] Parametrs;

        private SqlClientQuery()
        {
        }

        public override bool HaveParametrs()
        {
            return Parametrs != null;
        }

        internal static bool CreateNew(ImmutableArray<TypedConstant> namedArguments, INamedTypeSymbol containsType, out SqlClientQuery method)
        {
            method = null;
            if (namedArguments.Length != 9)
            {
                return false;
            }

            var methodSource = new SqlClientQuery();
            if (!methodSource.FillQuery(namedArguments[0]))
            {
                return false;
            }

            if (!methodSource.FillMapType(namedArguments[2]))
            {
                return false;
            }

            if (!methodSource.FillQueryType(namedArguments[4]))
            {
                return false;
            }

            if (!methodSource.FillGenerate(namedArguments[5]))
            {
                return false;
            }

            methodSource.MethodInfo =
                new BaseMethodInfo(
                    namedArguments[1],
                    namedArguments[3],
                    namedArguments[6],
                    namedArguments[7],
                    containsType
                    );

            if (methodSource.MapTypeName == null && methodSource.QueryType.HasFlag(QueryType.Read))
            {
                throw new Exception("For the 'Read' type, the mapping type must be specified");
            }

            methodSource.ContainTypeName = containsType;
            method = methodSource;
            if (!methodSource.SetPartInterfaceType(namedArguments[8]))
            {
                return false;
            }

            return true;
        }

        public override IEnumerable<BaseParametr> BaseParametrs()
        {
            return Parametrs.Cast<BaseParametr>();
        }
    }
}