using Gedaq.Base;
using Gedaq.Base.Query;

namespace Gedaq.SqlClient.GeneratorsQuery
{
    internal class SqlClientQueryScalarAndNonQuery : QueryScalarNonQueryBase
    {
        private readonly SqlClientProviderInfo _providerInfo;

        public SqlClientQueryScalarAndNonQuery(
            SqlClientCommandGenerator commandGenerator,
            SqlClientProviderInfo providerInfo)
            : base(commandGenerator)
        {
            _providerInfo = providerInfo;
        }

        protected override ProviderInfo ProviderInfo => _providerInfo;
    }
}