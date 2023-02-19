using Gedaq.Base;
using Gedaq.DbConnection.Model;
using Gedaq.Helpers;
using Microsoft.CodeAnalysis;

namespace Gedaq.Npgsql.Generators
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
            return Npgsql.Helpers.MapTypeHelper.IsKnownProviderType(type);
        }
    }
}