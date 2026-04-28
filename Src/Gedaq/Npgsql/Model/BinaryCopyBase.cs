using Gedaq.Base.Model;
using Gedaq.Helpers;
using Gedaq.Npgsql.Enums;
using Microsoft.CodeAnalysis;
using System;

namespace Gedaq.Npgsql.Model
{
    internal class BinaryCopyBase : BaseGenerateItem
    {
        protected int[] _npgSqlDbTypes;

        public NpgsqlSourceType SourceType { get; protected set; }

        public string Query;

        public bool IsDynamicQuery()
        {
            return Query == null;
        }

        public bool HaveNpgSqlDbTypes => _npgSqlDbTypes?.Length > 0;

        public override bool IsCollectionDelegateMap => MapTypeInfos?.Length > 1;

        public override string MapDelegateParametrName => throw new NotImplementedException();

        public override string MapDelegateParametrType()
        {
            throw new NotImplementedException();
        }

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

            _npgSqlDbTypes = new int[argument.Values.Length];
            for (int i = 0; i < argument.Values.Length; i++)
            {
                _npgSqlDbTypes[i] = (int)argument.Values[i].Value;
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

        public void SetAliases(MapTypeInfo mapTypeInfo, Aliases aliases)
        {
            if (_npgSqlDbTypes == null)
            {
                mapTypeInfo.Aliases = aliases;
                return;
            }

            var fields = aliases.AllFieldsOrderByPosition();
            if (_npgSqlDbTypes?.Length != fields.Count)
            {
                throw new Exception("The number of NpgSqlDbTypes and columns in the query does not match.");
            }

            for (int i = 0; i < fields.Count; i++)
            {
                Field field = fields[i];
                field.AdditionalInfo = new NpgsqlFieldInfo(_npgSqlDbTypes[i]);
            }

            mapTypeInfo.Aliases = aliases;
        }
    }
}