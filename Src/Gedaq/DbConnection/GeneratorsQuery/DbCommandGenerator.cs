using Gedaq.Base;
using Gedaq.Base.Model;
using Gedaq.Base.Query;
using Gedaq.DbConnection.Helpers;
using System.Text;

namespace Gedaq.DbConnection.GeneratorsQuery
{
    internal class DbCommandGenerator : CommandGeneratorBase
    {
        private readonly DbQueryCommon _queryCommon = new DbQueryCommon();
        protected override QueryCommonBase QueryCommon => _queryCommon;

        DbProviderInfo _providerInfo = new DbProviderInfo();
        protected override ProviderInfo ProviderInfo => _providerInfo;

        protected override void CreateParametr(BaseParametr baseParametr, int index, StringBuilder builder)
        {
            DbGeneratorHelper.CreateParametr(baseParametr, index, builder);
        }
    }
}