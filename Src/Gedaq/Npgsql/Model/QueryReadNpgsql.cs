using Gedaq.DbConnection.Model;
using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.Npgsql.Enums;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Immutable;

namespace Gedaq.Npgsql.Model
{
    internal class QueryReadNpgsql : QueryBase
    {
        public NpgsqlSourceType SourceType { get; private set; }
        public NpgsqlParametr[] Parametrs;

        public QueryReadNpgsql()
        {
        }

        public bool HaveParametrs()
        {
            return Parametrs != null;
        }

        internal static bool CreateNew(ImmutableArray<TypedConstant> namedArguments, INamedTypeSymbol containsType, out QueryReadNpgsql method)
        {
            method = null;
            if (namedArguments.Length != 7)
            {
                return false;
            }

            var methodSource = new QueryReadNpgsql();
            if (!methodSource.FillQuery(namedArguments[0]))
            {
                return false;
            }
            
            if(!methodSource.FillMapType(namedArguments[1]))
            {
                return false;
            }

            if (!methodSource.FillMethodType(namedArguments[2]))
            {
                return false;
            }

            if (!methodSource.FillSourceType(namedArguments[3]))
            {
                return false;
            }

            if (!methodSource.FillMethodName(namedArguments[4]))
            {
                return false;
            }

            if (!methodSource.FillQueryType(namedArguments[5]))
            {
                return false;
            }

            if (!methodSource.FillGenerate(namedArguments[6]))
            {
                return false;
            }

            methodSource.ContainTypeName = containsType;
            method = methodSource;
            return true;
        }

        private bool FillSourceType(TypedConstant argument)
        {
            if (argument.Kind != TypedConstantKind.Enum ||
                !(argument.Type is INamedTypeSymbol namedTypeSymbol4) ||
                !namedTypeSymbol4.IsAssignableFrom("Gedaq.Npgsql.Enums", "SourceType")
                )
            {
                return false;
            }

            SourceType = (NpgsqlSourceType)argument.Value;
            return true;
        }
    }
}