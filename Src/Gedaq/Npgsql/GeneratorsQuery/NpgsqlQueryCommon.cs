using Gedaq.Base.Model;
using Gedaq.Base.Query;
using Gedaq.Helpers;
using Gedaq.Npgsql.Helpers;
using Gedaq.SqlClient.Helpers;
using Microsoft.CodeAnalysis;

namespace Gedaq.Npgsql.GeneratorsQuery
{
    internal class NpgsqlQueryCommon : QueryCommonBase
    {
        public override string BatchType()
        {
            return "NpgsqlBatch";
        }

        public override string CommandType()
        {
            return "NpgsqlCommand";
        }

        public override string ReaderType()
        {
            return "NpgsqlDataReader";
        }

        public override string GetParametrValue(BaseParametr parametr, int index, string source)
        {
            if (parametr.Type.IsNullableType())
            {
                return $"((NpgsqlParameter){source}.Parameters[{index}]).Value";
            }
            else
            {
                return $"((NpgsqlParameter<{parametr.Type.GetFullTypeName()}>){source}.Parameters[{index}]).TypedValue";
            }
        }

        public override bool IsKnownProviderType(ITypeSymbol type)
        {
            return Npgsql.Helpers.NpgsqlMapTypeHelper.IsKnownProviderType(type);
        }

        public override bool IsSpecialHandlerType(ITypeSymbol type)
        {
            return false;
        }

        public override string GetSpecialTypeValue(ITypeSymbol type, int fieldId, string source = "reader")
        {
            throw new System.NotImplementedException();
        }
    }
}