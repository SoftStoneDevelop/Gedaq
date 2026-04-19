using Gedaq.Base;
using Gedaq.Base.Model;
using Gedaq.Base.Query;
using Gedaq.DbConnection.Helpers;
using System.Text;

namespace Gedaq.DbConnection.GeneratorsQuery
{
    internal class DbCommandGenerator : CommandGeneratorBase
    {
        private readonly DbProviderInfo _providerInfo;

        public DbCommandGenerator(DbProviderInfo providerInfo)
        {
            _providerInfo = providerInfo;
        }

        protected override ProviderInfo ProviderInfo => _providerInfo;

        protected override void CreateParametr(BaseParametr baseParametr, StringBuilder builder)
        {
            builder.Append($@"
                {{");
            DbGeneratorHelper.CreateParametr(baseParametr, builder);
            builder.Append($@"
                }}");
        }
    }
}