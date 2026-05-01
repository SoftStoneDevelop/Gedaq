using Gedaq.Base.Model;
using Gedaq.Helpers;
using Gedaq.Npgsql.Enums;
using Microsoft.CodeAnalysis;
using System;
using System.Linq;

namespace Gedaq.Npgsql.Model
{
    internal class BinaryCopyBase : BaseGenerateItem
    {
        protected int[][] _npgSqlDbTypes;

        public NpgsqlSourceType SourceType { get; protected set; }

        public string Query;

        public bool IsDynamicQuery()
        {
            return Query == null;
        }

        public bool HaveNpgSqlDbTypes => _npgSqlDbTypes?.Length > 0 && _npgSqlDbTypes.Any(a => a.Length > 0);

        public override bool IsCollectionDelegateMap => MapTypeInfos?.Length > 1;

        protected bool FillSourceType(TypedConstant argument)
        {
            if (argument.Kind != TypedConstantKind.Enum ||
                !(argument.Type is INamedTypeSymbol namedTypeSymbol4) ||
                !namedTypeSymbol4.IsAssignableFrom("Gedaq.Npgsql.Enums", "SourceType"))
            {
                return false;
            }

            SourceType = (NpgsqlSourceType)argument.Value;
            return true;
        }

        protected bool FillNpgsqlDbTypes(TypedConstant argument)
        {
            if (!(argument.Type is IArrayTypeSymbol arrayTypeSymbol) ||
                arrayTypeSymbol.Rank != 1 ||
                arrayTypeSymbol.ElementType.TypeKind != TypeKind.Enum ||
                !(arrayTypeSymbol.ElementType is INamedTypeSymbol elementType) ||
                !elementType.IsAssignableFrom("NpgsqlTypes", "NpgsqlDbType"))
            {
                return false;
            }

            if (argument.IsNull)
            {
                return true;
            }

            _npgSqlDbTypes = new int[][] { new int[argument.Values.Length]  };
            var types = _npgSqlDbTypes[0];
            for (int i = 0; i < argument.Values.Length; i++)
            {
                types[i] = (int)argument.Values[i].Value;
            }

            return true;
        }

        protected bool FillQuery(TypedConstant argument)
        {
            if (!(argument.Type is INamedTypeSymbol strParam) ||
                strParam.Name != nameof(String))
            {
                return false;
            }

            Query = (string)argument.Value;
            return true;
        }

        public void SetNpgSqlDbTypesOverride(int[] npgSqlDbTypeOverride, int indexOfMap)
        {
            if (_npgSqlDbTypes == null || _npgSqlDbTypes.Length <= indexOfMap)
            {
                _npgSqlDbTypes = new int[indexOfMap + 1][];
            }

            _npgSqlDbTypes[indexOfMap] = npgSqlDbTypeOverride;
        }

        /// <summary>
        /// Return not null if have override
        /// </summary>
        public int[] GetNpgSqlDbTypesOverride(int typeIndex)
        {
            if (!HaveMapTypes || _npgSqlDbTypes == null || _npgSqlDbTypes.Length <= typeIndex)
            {
                return null;
            }

            return _npgSqlDbTypes[typeIndex];
        }

        public void SetAliases(MapTypeInfo mapTypeInfo, Aliases aliases, int[] npgSqlDbTypeOverride)
        {
            if (npgSqlDbTypeOverride == null)
            {
                mapTypeInfo.Aliases = aliases;
                return;
            }

            var fields = aliases.AllFields();
            for (int i = 0; i < fields.Length && i < npgSqlDbTypeOverride.Length; i++)
            {
                Field field = fields[i];
                field.AdditionalInfo = new NpgsqlFieldInfo(npgSqlDbTypeOverride[i]);
            }

            mapTypeInfo.Aliases = aliases;
        }
    }
}