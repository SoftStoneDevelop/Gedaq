﻿using Gedaq.Base;
using Gedaq.Base.Model;
using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gedaq.Npgsql
{
    internal class NpgsqlProviderInfo : ProviderInfo
    {
        public override bool CanSetTransaction => false;

        public override string TransactionType()
        {
            throw new NotImplementedException();
        }

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

        public override string DefaultSourceType()
        {
            throw new System.NotImplementedException();
        }

        public override string DefaultSourceTypeParametr()
        {
            throw new System.NotImplementedException();
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