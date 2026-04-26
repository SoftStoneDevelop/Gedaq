using Gedaq.Base;
using Gedaq.Base.Query;

namespace Gedaq.DbConnection.GeneratorsQuery
{
    internal class DbQueryScalarAndNonQuery : QueryScalarNonQueryBase
    {
        private readonly DbProviderInfo _providerInfo;

        public DbQueryScalarAndNonQuery(
            DbCommandGenerator commandGenerator,
            DbProviderInfo providerInfo)
            : base(commandGenerator)
        {
            _providerInfo = providerInfo;
        }

        protected override ProviderInfo ProviderInfo => _providerInfo;
    }
}