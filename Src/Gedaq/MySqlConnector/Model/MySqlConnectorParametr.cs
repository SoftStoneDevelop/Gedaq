using Gedaq.Base.Model;
using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Immutable;

namespace Gedaq.MySqlConnector.Model
{
    internal class MySqlConnectorParametr : BaseParametr
    {
        public int MySqlDbType;
        public bool HaveMySqlDbType => MySqlDbType != 253;


        public override string VariableName(string postfix = default)
        {
            return $"{Name.ToLowerInvariant()}{postfix}";
        }

        internal static bool CreateNew(
            ImmutableArray<TypedConstant> namedArguments,
            INamedTypeSymbol containsType,
            out MySqlConnectorParametr parametr,
            out string methodName
            )
        {
            parametr = null;
            methodName = null;

            if (namedArguments.Length != 11)
            {
                return false;
            }

            var result = new MySqlConnectorParametr();
            if (!SetType(namedArguments[0], result))
            {
                return false;
            }

            if (!SetName(namedArguments[1], result))
            {
                return false;
            }

            if (!SetSqlDbType(namedArguments[2], result))
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

            if (!SetSourceColumn(namedArguments[6], result))
            {
                return false;
            }

            if (!SetSourceColumnNullMapping(namedArguments[7], result))
            {
                return false;
            }

            if (!SetSourceVersion(namedArguments[8], result))
            {
                return false;
            }

            if (!SetScale(namedArguments[9], result))
            {
                return false;
            }

            if (!SetPrecision(namedArguments[10], result))
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

        private static bool SetSqlDbType(TypedConstant argument, MySqlConnectorParametr parametr)
        {
            if (argument.Kind != TypedConstantKind.Enum ||
                !(argument.Type is INamedTypeSymbol dbType) ||
                !dbType.IsAssignableFrom("MySqlConnector", "MySqlDbType")
                )
            {
                return false;
            }

            parametr.MySqlDbType = (int)argument.Value;
            return true;
        }
    }
}