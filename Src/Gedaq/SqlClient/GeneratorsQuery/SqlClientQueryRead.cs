using Gedaq.Base;
using Gedaq.Base.Query;

namespace Gedaq.SqlClient.GeneratorsQuery
{
    internal class SqlClientQueryRead : QueryReadBase
    {
        private readonly SqlClientProviderInfo _providerInfo;

        public SqlClientQueryRead(
            SqlClientCommandGenerator commandGenerator,
            SqlClientProviderInfo providerInfo)
            : base(commandGenerator)
        {
            _providerInfo = providerInfo;
        }

        protected override ProviderInfo ProviderInfo => _providerInfo;
    }
}