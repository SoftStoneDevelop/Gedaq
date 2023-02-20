using Gedaq.Base.Model;
using Gedaq.Helpers;
using Gedaq.Npgsql.Model;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Data;
using System.Reflection;
using System.Text;

namespace Gedaq.DbConnection.Model
{
    internal class DbParametr : BaseParametr
    {
        public int DbType;
        public bool HaveDbType => DbType != 13;

        public override string VariableName(string postfix = default)
        {
            return $"{Name.ToLowerInvariant()}{postfix}";
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

            if (namedArguments.Length != 12)
            {
                return false;
            }

            if(!SetMethodName(namedArguments[0], ref methodName))
            {
                return false;
            }

            var result = new DbParametr();
            if (!SetName(namedArguments[1], result))
            {
                return false;
            }

            if (!SetType(namedArguments[2], result))
            {
                return false;
            }

            if (!SetDbType(namedArguments[3], result))
            {
                return false;
            }

            if(!SetSize(namedArguments[4], result))
            {
                return false;
            }

            if (!SetNullable(namedArguments[5], result))
            {
                return false;
            }

            if (!SetDirection(namedArguments[6], result))
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

            if (!result.HaveName)
            {
                throw new Exception("Parameter not have name");
            }

            parametr = result;
            return true;
        }

        private static bool SetDbType(TypedConstant argument, DbParametr parametr)
        {
            if (argument.Kind != TypedConstantKind.Enum ||
                !(argument.Type is INamedTypeSymbol dbType) ||
                !dbType.IsAssignableFrom("System.Data", "DbType")
                )
            {
                return false;
            }

            parametr.DbType = (int)argument.Value;
            return true;
        }
    }
}