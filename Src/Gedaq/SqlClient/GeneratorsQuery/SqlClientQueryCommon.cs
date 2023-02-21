using Gedaq.Base.Model;
using Gedaq.Base.Query;
using Gedaq.Helpers;
using Gedaq.SqlClient.Helpers;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gedaq.SqlClient.GeneratorsQuery
{
    internal class SqlClientQueryCommon : QueryCommonBase
    {
        public override string BatchType()
        {
            return "SqlBatch";
        }

        public override string CommandType()
        {
            return "SqlCommand";
        }

        public override string ReaderType()
        {
            return "SqlDataReader";
        }

        public override string GetParametrValue(BaseParametr parametr, int index, string source)
        {
            return $"{source}.Parameters[{index}].Value";
        }

        public override bool IsKnownProviderType(ITypeSymbol type)
        {
            return SqlClientMapTypeHelper.IsKnownProviderType(type);
        }

        public override bool IsSpecialHandlerType(ITypeSymbol type)
        {
            return SqlClientMapTypeHelper.IsSpecialHandlerType(type);
        }

        public override string GetSpecialTypeValue(ITypeSymbol type, int fieldId, string source = "reader")
        {
            switch (type.GetFullTypeName())
            {
                case "System.Data.SqlTypes.SqlXml":
                {
                    return $"{source}.GetSqlXml({fieldId})";
                }

                default:
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}