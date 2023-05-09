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
    internal class NpgsqlQuery : QueryBaseCommand
    {
        public NpgsqlSourceType SourceType { get; private set; }
        public NpgsqlParametr[] Parametrs;

        public NpgsqlQuery()
        {
        }

        public override bool HaveParametrs()
        {
            return Parametrs != null;
        }

        internal static bool CreateNew(ImmutableArray<TypedConstant> namedArguments, INamedTypeSymbol containsType, out NpgsqlQuery method)
        {
            method = null;
            if (namedArguments.Length != 8)
            {
                return false;
            }

            var methodSource = new NpgsqlQuery();
            if (!methodSource.FillQuery(namedArguments[0]))
            {
                return false;
            }

            if (!methodSource.FillMapType(namedArguments[2]))
            {
                return false;
            }

            if (!methodSource.FillSourceType(namedArguments[4]))
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

            methodSource.MethodInfo =
                new BaseMethodInfo(
                    namedArguments[1],
                    namedArguments[3],
                    namedArguments[7],
                    containsType
                    );

            if (methodSource.MapTypeName == null && methodSource.QueryType.HasFlag(QueryType.Read))
            {
                throw new Exception("For the 'Read' type, the mapping type must be specified");
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

        public override IEnumerable<BaseParametr> BaseParametrs()
        {
            return Parametrs.Cast<BaseParametr>();
        }
    }
}