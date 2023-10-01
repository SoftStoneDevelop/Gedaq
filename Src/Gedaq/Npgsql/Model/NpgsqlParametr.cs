using Gedaq.Base.Model;
using Gedaq.DbConnection.Model;
using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Immutable;
using System.Data;

namespace Gedaq.Npgsql.Model
{
    internal class NpgsqlParametr : BaseParametr
    {
        public int Position;
        public bool HavePosition => Position != -1;

        public int NpgSqlDbType;
        public bool HaveNpgSqlDbType => NpgSqlDbType != 40;

        public override string VariableName(string postfix = default)
        {
            if (HaveNameInMethod)
            {
                return $"{NameInMethod}{postfix}";
            }

            return HaveNameInCommand ?
                    $"{NameInCommand}{postfix}" :
                    $"mParametr{Index}{postfix}"
                ;
        }

        internal static bool CreateNew(
            ImmutableArray<TypedConstant> namedArguments,
            INamedTypeSymbol containsType,
            out NpgsqlParametr parametr,
            out string methodName
            )
        {
            parametr = null;
            methodName = null;

            if (namedArguments.Length != 13)
            {
                return false;
            }

            var result = new NpgsqlParametr();
            if (!SetType(namedArguments[0], result))
            {
                return false;
            }

            if (!SetNameInCommand(namedArguments[1], result))
            {
                return false;
            }

            if(!SetNpgSqlDbType(namedArguments[2], result))
            {
                return false;
            }

            if (!SetSize(namedArguments[3], result))
            {
                return false;
            }

            if (!SetNullable(namedArguments[4], result))
            {
                return false;
            }

            if (!SetDirection(namedArguments[5], result))
            {
                return false;
            }

            if (!SetPosition(namedArguments[6], result))
            {
                return false;
            }

            if (!SetSourceColumn(namedArguments[7], result))
            {
                return false;
            }

            if (!SetSourceColumnNullMapping(namedArguments[8], result))
            {
                return false;
            }

            if (!SetSourceVersion(namedArguments[9], result))
            {
                return false;
            }

            if (!SetScale(namedArguments[10], result))
            {
                return false;
            }

            if (!SetPrecision(namedArguments[11], result))
            {
                return false;
            }

            if (!SetNameInMethod(namedArguments[12], result))
            {
                return false;
            }

            if (result.HaveNameInCommand && result.HavePosition)
            {
                throw new Exception("Parameter can have position or name, but not both");
            }

            if(!result.HaveNameInCommand && !result.HavePosition)
            {
                throw new Exception("Parameter not have position or name");
            }

            parametr = result;
            return true;
        }

        private static bool SetNpgSqlDbType(TypedConstant argument, NpgsqlParametr parametr)
        {
            if (argument.Kind != TypedConstantKind.Enum ||
                !(argument.Type is INamedTypeSymbol dbType) ||
                !dbType.IsAssignableFrom("NpgsqlTypes", "NpgsqlDbType")
                )
            {
                return false;
            }

            parametr.NpgSqlDbType = (int)argument.Value;
            return true;
        }

        protected static bool SetPosition(TypedConstant argument, NpgsqlParametr parametr)
        {
            if (!(argument.Type is INamedTypeSymbol sizeParam) ||
                sizeParam.Name != nameof(Int32)
                )
            {
                return false;
            }

            parametr.Position = (int)argument.Value;
            return true;
        }
    }
}