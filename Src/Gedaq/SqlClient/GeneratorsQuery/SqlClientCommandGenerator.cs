using Gedaq.Base;
using Gedaq.Base.Model;
using Gedaq.Base.Query;
using Gedaq.DbConnection.Helpers;
using Gedaq.Npgsql;
using Gedaq.SqlClient.Helpers;
using System.Text;

namespace Gedaq.SqlClient.GeneratorsQuery
{
    internal class SqlClientCommandGenerator : CommandGeneratorBase
    {
        SqlClientProviderInfo _providerInfo = new SqlClientProviderInfo();
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