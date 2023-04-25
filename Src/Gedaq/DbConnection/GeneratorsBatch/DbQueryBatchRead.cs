using Gedaq.Base;
using Gedaq.Base.Batch;

namespace Gedaq.DbConnection.GeneratorsBatch
{
    internal class DbQueryBatchRead : QueryBatchReadBase
    {
        DbProviderInfo _providerInfo = new DbProviderInfo();
        protected override ProviderInfo ProviderInfo => _providerInfo;
    }
}
