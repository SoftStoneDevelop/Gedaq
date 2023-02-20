using Gedaq.Base.Model;
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

        public override string VariableName(string postfix = default)
        {
            return HaveName ?
                    $"{Name.ToLowerInvariant()}{postfix}" :
                    $"mParametr{Position}{postfix}"
                ;
        }

        public bool HaveNpgSqlDbType => NpgSqlDbType != 40;

        internal static bool CreateNew(
            ImmutableArray<TypedConstant> namedArguments,
            INamedTypeSymbol containsType,
            out NpgsqlParametr parametr,
            out string methodName
            )
        {
            parametr = null;
            methodName = null;

            if (namedArguments.Length != 8)
            {
                return false;
            }

            if (!(namedArguments[0].Type is INamedTypeSymbol strParam) ||
                strParam.Name != nameof(String)
                )
            {
                return false;
            }

            methodName = (string)namedArguments[0].Value;

            var result = new NpgsqlParametr();
            if (!(namedArguments[1].Value is ITypeSymbol typeParam))
            {
                return false;
            }

            result.Type = typeParam;

            if (!(namedArguments[2].Type is INamedTypeSymbol paramName) ||
                paramName.Name != nameof(String)
                )
            {
                return false;
            }

            result.Name = (string)namedArguments[2].Value;

            if (namedArguments[3].Kind != TypedConstantKind.Enum ||
                !(namedArguments[3].Type is INamedTypeSymbol dbType) ||
                !dbType.IsAssignableFrom("NpgsqlTypes", "NpgsqlDbType")
                )
            {
                return false;
            }

            result.NpgSqlDbType = (int)namedArguments[3].Value;

            if (!(namedArguments[4].Type is INamedTypeSymbol sizeParam) ||
                sizeParam.Name != nameof(Int32)
                )
            {
                return false;
            }

            result.Size = (int)namedArguments[4].Value;

            if (!(namedArguments[5].Type is INamedTypeSymbol nullableParam) ||
                nullableParam.Name != nameof(Boolean)
                )
            {
                return false;
            }

            result.Nullable = (bool)namedArguments[5].Value;

            if (namedArguments[6].Kind != TypedConstantKind.Enum ||
                !(namedArguments[6].Type is INamedTypeSymbol directionParam) ||
                !directionParam.IsAssignableFrom("System.Data", "ParameterDirection")
                )
            {
                return false;
            }

            result.Direction = (ParameterDirection)namedArguments[6].Value;

            if (!(namedArguments[7].Type is INamedTypeSymbol positionParam) ||
                positionParam.Name != nameof(Int32)
                )
            {
                return false;
            }

            result.Position = (int)namedArguments[7].Value;

            if(result.HaveName && result.HavePosition)
            {
                throw new Exception("Parameter can have position or name, but not both");
            }

            if(!result.HaveName && !result.HavePosition)
            {
                throw new Exception("Parameter not have position or name");
            }

            parametr = result;
            return true;
        }
    }
}