using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Immutable;
using System.Data;

namespace Gedaq.Npgsql.Model
{
    internal class Parametr
    {
        public int Position;
        public string Name;
        public ITypeSymbol Type;
        public int DbType;
        public int Size;
        public int NumberInBatch;
        public bool Nullable;
        public ParameterDirection Direction;

        public bool HaveName => Name != null;
        public bool HaveDbType => DbType != 40;
        public bool HaveSize => Size != -1;

        public bool HavePosition => Position != -1;

        public string VariableName()
        {
            return HaveName ?
                    Name.ToLowerInvariant() :
                    $"mParametr{Position}"
                ;
        }

        internal static bool CreateNew(
            ImmutableArray<TypedConstant> namedArguments,
            INamedTypeSymbol containsType,
            out Parametr parametr,
            out string methodName
            )
        {
            parametr = null;
            methodName = null;

            if (namedArguments.Length != 9)
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

            var result = new Parametr();
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
                !dbType.IsAssignableFrom("NpgsqlTypes", "NpgsqlDbType")
                )
            {
                return false;
            }

            result.DbType = (int)namedArguments[3].Value;

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

            if (!(namedArguments[7].Type is INamedTypeSymbol numberBatchParam) ||
                numberBatchParam.Name != nameof(Int32)
                )
            {
                return false;
            }

            result.NumberInBatch = (int)namedArguments[7].Value;

            if (!(namedArguments[8].Type is INamedTypeSymbol positionParam) ||
                positionParam.Name != nameof(Int32)
                )
            {
                return false;
            }

            result.Position = (int)namedArguments[8].Value;

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