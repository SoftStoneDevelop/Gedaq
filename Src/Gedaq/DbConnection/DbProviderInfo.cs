using Gedaq.Base;
using Gedaq.Base.Model;
using Gedaq.DbConnection.Helpers;
using Microsoft.CodeAnalysis;
using System;

namespace Gedaq.DbConnection
{
    internal class DbProviderInfo : ProviderInfo
    {
        public override bool CanSetTransaction => true;

        public override string TransactionType()
        {
            return "DbTransaction";
        }

        public override string BatchType()
        {
            return "DbBatch";
        }

        public override string CommandType()
        {
            return "DbCommand";
        }

        public override string ReaderType()
        {
            return "DbDataReader";
        }

        public override string DefaultSourceType()
        {
            return "DbConnection";
        }

        public override string DefaultSourceTypeParametr()
        {
            return "connection";
        }

        public override string GetParametrValue(BaseParametr parametr, string source)
        {
            return $"{source}.Parameters[{parametr.Index}].Value";
        }

        public override string GetNullValue(BaseParametr parametr)
        {
            return $"DBNull.Value";
        }

        public override bool IsKnownProviderType(ITypeSymbol type)
        {
            return DbMapTypeHelper.IsKnownProviderType(type);
        }

        public override bool IsSpecialHandlerType(ITypeSymbol type)
        {
            return false;
        }

        public override string GetSpecialTypeValue(ITypeSymbol type, int fieldId, string source = "reader")
        {
            throw new NotImplementedException();
        }
    }
}