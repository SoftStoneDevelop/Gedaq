using Gedaq.Base.Batch;
using Gedaq.Base.Model;
using Gedaq.DbConnection.Helpers;
using Gedaq.Npgsql.Helpers;
using Microsoft.CodeAnalysis;

namespace Gedaq.DbConnection.GeneratorsBatch
{
    internal class DbBatchCommon : BatchCommonGenerator
    {
        public override string BatchType()
        {
            return "DbBatch";
        }

        public override string CommandType()
        {
            return "DbCommand";
        }

        public override bool IsKnownProviderType(ITypeSymbol type)
        {
            return DbMapTypeHelper.IsKnownProviderType(type);
        }

        public override string ReaderType()
        {
            return "DbDataReader";
        }

        public override string GetParametrValue(BaseParametr parametr, int index, string source)
        {
            return $"{source}.Parameters[{index}].Value";
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