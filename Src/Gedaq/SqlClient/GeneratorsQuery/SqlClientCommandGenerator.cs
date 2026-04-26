using Gedaq.Base;
using Gedaq.Base.Model;
using Gedaq.Base.Query;
using Gedaq.SqlClient.Helpers;
using System.Text;

namespace Gedaq.SqlClient.GeneratorsQuery
{
    internal class SqlClientCommandGenerator : CommandGeneratorBase
    {
        private readonly SqlClientProviderInfo _providerInfo;

        public SqlClientCommandGenerator(SqlClientProviderInfo providerInfo)
        {
            _providerInfo = providerInfo;
        }

        protected override ProviderInfo ProviderInfo => _providerInfo;

        protected override void CreateParametr(BaseParametr baseParametr, StringBuilder builder)
        {
            builder.Append($@"
                {{");
            SqlClientGeneratorHelper.CreateParametr(baseParametr, builder);
            builder.Append($@"
                }}");
        }
    }
}