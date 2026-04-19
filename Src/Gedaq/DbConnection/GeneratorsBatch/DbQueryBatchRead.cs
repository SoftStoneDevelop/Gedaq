using Gedaq.Base;
using Gedaq.Base.Batch;

namespace Gedaq.DbConnection.GeneratorsBatch
{
    internal class DbQueryBatchRead : QueryBatchReadBase
    {
        private readonly DbProviderInfo _providerInfo;

        public DbQueryBatchRead(
            BatchCommandBase commandGenerator,
            DbProviderInfo providerInfo)
            : base(commandGenerator)
        {
            _providerInfo = providerInfo;
        }

        protected override ProviderInfo ProviderInfo => _providerInfo;
    }
}