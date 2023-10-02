using Gedaq.Base;
using Gedaq.Base.Query;

namespace Gedaq.SqlClient.GeneratorsQuery
{
    internal class SqlClientQueryScalarAndNonQuery : QueryScalarNonQueryBase
    {
        private readonly SqlClientProviderInfo _providerInfo = new SqlClientProviderInfo();

        public SqlClientQueryScalarAndNonQuery(SqlClientCommandGenerator commandGenerator) : base(commandGenerator)
        {

        }

        protected override ProviderInfo ProviderInfo => _providerInfo;
    }
}