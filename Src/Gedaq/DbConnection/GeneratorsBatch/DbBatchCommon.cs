using Gedaq.Base.Batch;
using Gedaq.Base.Model;
using Gedaq.Helpers;
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
    }
}