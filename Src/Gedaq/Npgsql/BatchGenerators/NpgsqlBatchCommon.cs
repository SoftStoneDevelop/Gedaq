using Gedaq.Base.Batch;
using Gedaq.Base.Model;
using Gedaq.Helpers;
using Gedaq.Npgsql.Helpers;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;

namespace Gedaq.Npgsql.BatchGenerators
{
    internal class NpgsqlBatchCommon : BatchCommonGenerator
    {
        public override string BatchType()
        {
            return "NpgsqlBatch";
        }

        public override string CommandType()
        {
            return "NpgsqlCommand";
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
            return NpgsqlMapTypeHelper.IsKnownProviderType(type);
        }

        public override string ReaderType()
        {
            return "NpgsqlDataReader";
        }
    }
}