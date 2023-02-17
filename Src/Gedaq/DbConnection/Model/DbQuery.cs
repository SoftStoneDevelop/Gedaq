using Gedaq.Npgsql.Model;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace Gedaq.DbConnection.Model
{
    internal class DbQuery : QueryBase
    {
        public DbParametr[] Parametrs;
        public bool HaveParametrs()
        {
            return Parametrs != null;
        }

        internal static bool CreateNew(ImmutableArray<TypedConstant> namedArguments, INamedTypeSymbol containsType, out DbQuery query)
        {
            query = null;
            if (namedArguments.Length != 6)
            {
                return false;
            }

            var methodSource = new DbQuery();
            if (!methodSource.FillQuery(namedArguments[0]))
            {
                return false;
            }

            if (!methodSource.FillMapType(namedArguments[1]))
            {
                return false;
            }

            if (!methodSource.FillMethodType(namedArguments[2]))
            {
                return false;
            }

            if (!methodSource.FillMethodName(namedArguments[3]))
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

            methodSource.ContainTypeName = containsType;
            query = methodSource;
            return true;
        }
    }
}