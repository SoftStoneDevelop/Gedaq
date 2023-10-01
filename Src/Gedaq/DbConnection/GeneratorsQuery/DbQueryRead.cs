using Gedaq.Base;
using Gedaq.Base.Query;

namespace Gedaq.DbConnection.GeneratorsQuery
{
    internal class DbQueryRead : QueryReadBase
    {
        private readonly DbProviderInfo _dbProviderInfo = new DbProviderInfo();

        public DbQueryRead(DbCommandGenerator commandGenerator) : base(commandGenerator)
        {

        }

        protected override ProviderInfo ProviderInfo => _dbProviderInfo;
    }
}