using Gedaq.Base;
using Gedaq.Base.Model;
using Gedaq.Helpers;
using Gedaq.SqlClient.Helpers;
using Microsoft.CodeAnalysis;
using System;

namespace Gedaq.SqlClient
{
    internal class SqlClientProviderInfo : ProviderInfo
    {
        public override bool CanSetTransaction => true;

        public override string TransactionType()
        {
            return "SqlTransaction";
        }

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

        public override string DefaultSourceType()
        {
            return "SqlConnection";
        }

        public override string DefaultSourceTypeParametr()
        {
            return "connection";
        }

        public override string GetParametrType()
        {
            return "SqlParameter";
        }

        public override string GetParametrValue(BaseParametr parametr, string source)
        {
            return $"{source}.Parameters[{parametr.Index}].Value";
        }

        public override string GetNullValue(BaseParametr parametr)
        {
            return $"DBNull.Value";
        }

        protected override bool IsKnownProviderTypeInner(ITypeSymbol type)
        {
            return SqlClientMapTypeHelper.IsKnownProviderType(type);
        }

        public override bool IsSpecialHandlerType(ITypeSymbol type)
        {
            return SqlClientMapTypeHelper.IsSpecialHandlerType(type);
        }

        public override string GetSpecialTypeValue(
            ITypeSymbol type,
            string aliasesPrefix,
            Field field,
            string source = "reader")
        {
            switch (type.GetFullTypeName())
            {
                case "System.Data.SqlTypes.SqlXml":
                {
                    return $"{source}.GetSqlXml({ValueReaderKey(aliasesPrefix, field)})";
                }

                default:
                {
                    throw new NotImplementedException();
                }
            }
        }

        public override bool GetValueFromReader(ITypeSymbol typeOfValue, out string getMethod)
        {
            if (base.GetValueFromReader(typeOfValue, out getMethod))
            {
                return true;
            }

            switch (typeOfValue.GetFullTypeName(replaceNullable: true, addQuestionNoatble: false))
            {
                case "System.TimeSpan":
                {
                    getMethod = "GetTimeSpan";
                    return true;
                }

                case "System.DateTimeOffset":
                {
                    getMethod = "GetDateTimeOffset";
                    return true;
                }

                default:
                {
                    getMethod = null;
                    return false;
                }
            }
        }
    }
}