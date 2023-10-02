using Gedaq.Base;
using Gedaq.Base.Query;

namespace Gedaq.SqlClient.GeneratorsQuery
{
    internal class SqlClientQueryRead : QueryReadBase
    {
        private readonly SqlClientProviderInfo _providerInfo = new SqlClientProviderInfo();

        public SqlClientQueryRead(SqlClientCommandGenerator commandGenerator) : base(commandGenerator)
        {

        }

        protected override ProviderInfo ProviderInfo => _providerInfo;
    }
}