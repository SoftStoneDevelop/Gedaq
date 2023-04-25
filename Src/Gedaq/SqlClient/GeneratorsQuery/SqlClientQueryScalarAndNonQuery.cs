using Gedaq.Base;
using Gedaq.Base.Query;
using Gedaq.Npgsql;

namespace Gedaq.SqlClient.GeneratorsQuery
{
    internal class SqlClientQueryScalarAndNonQuery : QueryScalarNonQueryBase
    {
        private readonly SqlClientProviderInfo _providerInfo = new SqlClientProviderInfo();
        protected override ProviderInfo ProviderInfo => _providerInfo;
    }
}