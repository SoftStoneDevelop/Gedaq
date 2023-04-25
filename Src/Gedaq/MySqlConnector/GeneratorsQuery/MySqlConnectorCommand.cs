using Gedaq.Base;
using Gedaq.Base.Model;
using Gedaq.Base.Query;
using Gedaq.Enums;
using Gedaq.MySqlConnector.Enums;
using Gedaq.MySqlConnector.Helpers;
using Gedaq.MySqlConnector.Model;
using System.Text;

namespace Gedaq.MySqlConnector.GeneratorsQuery
{
    internal class MySqlConnectorCommand : CommandGeneratorBase
    {
        MySqlConnectorProviderInfo _providerInfo = new MySqlConnectorProviderInfo();
        protected override ProviderInfo ProviderInfo => _providerInfo;

        protected override void GenrateCommand(QueryBase baseSource, StringBuilder builder)
        {
            MySqlConnectorQuery source = (MySqlConnectorQuery)baseSource;
            if (baseSource.MethodType.HasFlag(MethodType.Sync))
            {
                if (source.SourceType.HasFlag(MySqlConnectorSourceType.MySqlConnection))
                {
                    CreateCommandMethod(
                        baseSource,
                        MySqlConnectorSourceType.MySqlConnection.ToTypeName(),
                        MySqlConnectorSourceType.MySqlConnection.ToParametrName(),
                        MethodType.Sync, builder
                        );
                }

                if (source.SourceType.HasFlag(MySqlConnectorSourceType.MySqlDataSource))
                {
                    CreateCommandMethod(
                        baseSource,
                        MySqlConnectorSourceType.MySqlDataSource.ToTypeName(),
                        MySqlConnectorSourceType.MySqlDataSource.ToParametrName(),
                        MethodType.Sync, builder
                        );
                }
            }

            if (baseSource.MethodType.HasFlag(MethodType.Async))
            {
                if (source.SourceType.HasFlag(MySqlConnectorSourceType.MySqlConnection))
                {
                    CreateCommandMethod(
                        baseSource,
                        MySqlConnectorSourceType.MySqlConnection.ToTypeName(),
                        MySqlConnectorSourceType.MySqlConnection.ToParametrName(),
                        MethodType.Async, builder
                        );
                }

                if (source.SourceType.HasFlag(MySqlConnectorSourceType.MySqlDataSource))
                {
                    CreateCommandMethod(
                        baseSource,
                        MySqlConnectorSourceType.MySqlDataSource.ToTypeName(),
                        MySqlConnectorSourceType.MySqlDataSource.ToParametrName(),
                        MethodType.Async, builder
                        );
                }
            }
        }

        protected override void CreateParametr(BaseParametr baseParametr, int index, StringBuilder builder)
        {
            MySqlConnectorGeneratorHelper.CreateParametr(baseParametr, index, builder);
        }
    }
}