using Gedaq.Base.Batch;
using Gedaq.Base.Model;
using Gedaq.MySqlConnector.Helpers;
using Microsoft.CodeAnalysis;

namespace Gedaq.MySqlConnector.GeneratorsBatch
{
    internal class MySqlConnectorBatchCommon : BatchCommonGenerator
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

        public override string GetParametrValue(BaseParametr parametr, int index, string source)
        {
            return $"{source}.Parameters[{index}].Value";
        }

        public override bool IsKnownProviderType(ITypeSymbol type)
        {
            return MySqlConnectorMapTypeHelper.IsKnownProviderType(type);
        }

        public override bool IsSpecialHandlerType(ITypeSymbol type)
        {
            return MySqlConnectorMapTypeHelper.IsSpecialHandlerType(type);
        }

        public override string GetSpecialTypeValue(ITypeSymbol type, int fieldId, string source = "reader")
        {
            throw new System.NotImplementedException();
        }

        public override string DefaultSourceType()
        {
            throw new System.NotImplementedException();
        }

        public override string DefaultSourceTypeParametr()
        {
            throw new System.NotImplementedException();
        }
    }
}