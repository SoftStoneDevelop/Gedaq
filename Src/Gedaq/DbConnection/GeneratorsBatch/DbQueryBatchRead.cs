using Gedaq.Base;
using Gedaq.Base.Batch;

namespace Gedaq.DbConnection.GeneratorsBatch
{
    internal class DbQueryBatchRead : QueryBatchReadBase
    {
        DbBatchCommon _batchCommon = new DbBatchCommon();
        protected override BatchCommonBase BatchCommon => _batchCommon;

        DbProviderInfo _providerInfo = new DbProviderInfo();
        protected override ProviderInfo ProviderInfo => _providerInfo;
    }
}
