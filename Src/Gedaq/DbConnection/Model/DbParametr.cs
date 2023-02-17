using Gedaq.Helpers;
using Gedaq.Npgsql.Model;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Data;
using System.Text;

namespace Gedaq.DbConnection.Model
{
    internal class DbParametr : BaseParametr
    {
        public System.Data.DbType? DbType;
        public bool HaveDbType => DbType.HasValue;

        public override string VariableName()
        {
            return Name.ToLowerInvariant();
        }

        internal static bool CreateNew(
            ImmutableArray<TypedConstant> namedArguments,
            INamedTypeSymbol containsType,
            out DbParametr parametr,
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

            var result = new DbParametr();
            if (!(namedArguments[1].Type is INamedTypeSymbol paramName) ||
                paramName.Name != nameof(String)
                )
            {
                return false;
            }

            result.Name = (string)namedArguments[1].Value;

            if (!(namedArguments[2].Value is ITypeSymbol typeParam))
            {
                return false;
            }

            result.Type = typeParam;

            if (namedArguments[3].Kind != TypedConstantKind.Enum ||
                !(namedArguments[3].Type is INamedTypeSymbol dbType) ||
                !dbType.IsAssignableFrom("System.Data", "DbType")
                )
            {
                return false;
            }

            result.DbType = (System.Data.DbType)namedArguments[3].Value;

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

            if (!result.HaveName)
            {
                throw new Exception("Parameter not have name");
            }

            parametr = result;
            return true;
        }
    }
}