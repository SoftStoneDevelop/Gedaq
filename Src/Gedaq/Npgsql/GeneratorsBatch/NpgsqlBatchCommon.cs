using Gedaq.Base.Batch;
using Gedaq.Base.Model;
using Gedaq.Helpers;
using Gedaq.Npgsql.Helpers;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;

namespace Gedaq.Npgsql.GeneratorsBatch
{
    internal class NpgsqlBatchCommon : BatchCommonBase
    {
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