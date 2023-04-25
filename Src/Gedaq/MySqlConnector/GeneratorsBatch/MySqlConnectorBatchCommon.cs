using Gedaq.Base;
using Gedaq.Base.Batch;
using Gedaq.Base.Model;
using Gedaq.MySqlConnector.Helpers;
using Microsoft.CodeAnalysis;

namespace Gedaq.MySqlConnector.GeneratorsBatch
{
    internal class MySqlConnectorBatchCommon : BatchCommonBase
    {
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
    }
}