using Gedaq.Base;
using Gedaq.Base.Model;
using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gedaq.DbConnection.Generators
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
    }
}