using Gedaq.Base;
using Gedaq.Base.Batch;

namespace Gedaq.DbConnection.GeneratorsBatch
{
    internal class DbQueryBatchRead : QueryBatchReadBase
    {
        DbProviderInfo _providerInfo = new DbProviderInfo();

        public DbQueryBatchRead(BatchCommandBase commandGenerator) : base(commandGenerator)
        {

        }

        protected override ProviderInfo ProviderInfo => _providerInfo;
    }
}