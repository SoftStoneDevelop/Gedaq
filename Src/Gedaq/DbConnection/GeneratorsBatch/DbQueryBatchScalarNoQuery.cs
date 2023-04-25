using Gedaq.Base;
using Gedaq.Base.Batch;

namespace Gedaq.DbConnection.GeneratorsBatch
{
    internal class DbQueryBatchScalarNoQuery : QueryBatchScalarNoQueryBase
    {
        DbProviderInfo _providerInfo = new DbProviderInfo();
        protected override ProviderInfo ProviderInfo => _providerInfo;
    }
}