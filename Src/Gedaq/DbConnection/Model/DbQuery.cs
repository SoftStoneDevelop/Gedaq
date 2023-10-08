using Gedaq.Base.Model;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace Gedaq.DbConnection.Model
{
    internal class DbQuery : QueryBaseCommand
    {
        public DbParametr[] Parametrs;
        public override bool HaveParametrs()
        {
            return Parametrs?.Length != 0;
        }

        internal static bool CreateNew(ImmutableArray<TypedConstant> namedArguments, INamedTypeSymbol containsType, out DbQuery query)
        {
            query = null;
            if (namedArguments.Length != 10)
            {
                return false;
            }

            var methodSource = new DbQuery();
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
            methodSource.ContainTypeName = containsType;
            query = methodSource;

            if (!methodSource.SetPartInterfaceType(namedArguments[8]))
            {
                return false;
            }

            if (!methodSource.FillReturnType(namedArguments[9]))
            {
                return false;
            }

            return true;
        }

        public override IEnumerable<BaseParametr> BaseParametrs()
        {
            return Parametrs;
        }
    }
}