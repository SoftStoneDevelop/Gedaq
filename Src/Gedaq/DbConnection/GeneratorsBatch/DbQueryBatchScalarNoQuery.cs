using Gedaq.Base;
using Gedaq.Base.Batch;

namespace Gedaq.DbConnection.GeneratorsBatch
{
    internal class DbQueryBatchScalarNoQuery : QueryBatchScalarNoQueryBase
    {
        private readonly DbProviderInfo _providerInfo;

        public DbQueryBatchScalarNoQuery(
            DbBatchCommand commandGenerator,
            DbProviderInfo providerInfo)
            : base(commandGenerator)
        {
            _providerInfo = providerInfo;
        }

        protected override ProviderInfo ProviderInfo => _providerInfo;
    }
}