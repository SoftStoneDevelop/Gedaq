using Gedaq.Base;
using Gedaq.Base.Model;
using Gedaq.Helpers;
using Gedaq.MySqlConnector.Helpers;
using Microsoft.CodeAnalysis;

namespace Gedaq.MySqlConnector
{
    internal class MySqlConnectorProviderInfo : ProviderInfo
    {
        public override bool CanSetTransaction => true;

        public override string TransactionType()
        {
            return "MySqlTransaction";
        }

        public override string BatchType()
        {
            return "MySqlBatch";
        }

        public override string CommandType()
        {
            return "MySqlCommand";
        }

        public override string ReaderType()
        {
            return "MySqlDataReader";
        }

        public override string DefaultSourceType()
        {
            throw new System.NotImplementedException();
        }

        public override string DefaultSourceTypeParametr()
        {
            throw new System.NotImplementedException();
        }

        public override string GetParametrType()
        {
            return "MySqlParameter";
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
            return MySqlConnectorMapTypeHelper.IsKnownProviderType(type);
        }

        public override bool IsSpecialHandlerType(ITypeSymbol type)
        {
            return MySqlConnectorMapTypeHelper.IsSpecialHandlerType(type);
        }

        public override string GetSpecialTypeValue(
            ITypeSymbol type,
            string aliasesPrefix,
            Field field,
            string source = "reader")
        {
            throw new System.NotImplementedException();
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

                case "System.DateOnly":
                {
                    getMethod = "GetDateOnly";
                    return true;
                }

                case "System.TimeOnly":
                {
                    getMethod = "GetTimeOnly";
                    return true;
                }

                case "System.SByte":
                {
                    getMethod = "GetSByte";
                    return true;
                }

                case "System.UInt16":
                {
                    getMethod = "GetUInt16";
                    return true;
                }

                case "System.UInt32":
                {
                    getMethod = "GetUInt32";
                    return true;
                }

                case "System.UInt64":
                {
                    getMethod = "GetUInt64";
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