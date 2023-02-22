using Gedaq.Base.Model;
using Gedaq.Base.Query;
using Gedaq.DbConnection.Helpers;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gedaq.DbConnection.GeneratorsQuery
{
    internal class DbQueryCommon : QueryCommonBase
    {
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

        public override string GetParametrValue(BaseParametr parametr, int index, string source)
        {
            return $"{source}.Parameters[{index}].Value";
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

        public override string DefaultSourceType()
        {
            return "DbConnection";
        }

        public override string DefaultSourceTypeParametr()
        {
            return "connection";
        }
    }
}