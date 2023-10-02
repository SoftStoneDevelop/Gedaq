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
    internal class MySqlConnectorQueryRead : QueryReadBase
    {
        private readonly MySqlConnectorProviderInfo _providerInfo = new MySqlConnectorProviderInfo();

        public MySqlConnectorQueryRead(MySqlConnectorCommand commandGenerator) : base(commandGenerator)
        {

        }

        protected override ProviderInfo ProviderInfo => _providerInfo;

        protected override void ReadMethod(
            QueryBaseCommand source, 
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator
            )
        {
            MySqlConnectorQuery query = (MySqlConnectorQuery)source;
            if (query.SourceType.HasFlag(MySqlConnectorSourceType.MySqlConnection))
            {
                ReadMethodInner(
                    source,
                    MethodType.Sync,
                    builder,
                    MySqlConnectorSourceType.MySqlConnection.ToTypeName(),
                    MySqlConnectorSourceType.MySqlConnection.ToParametrName(),
                    needCheckOpen: true,
                    interfaceGenerator
                    );
            }

            if (query.SourceType.HasFlag(MySqlConnectorSourceType.MySqlDataSource))
            {
                ReadMethodInner(
                    source,
                    MethodType.Sync,
                    builder,
                    MySqlConnectorSourceType.MySqlDataSource.ToTypeName(),
                    MySqlConnectorSourceType.MySqlDataSource.ToParametrName(),
                    needCheckOpen: false,
                    interfaceGenerator
                    );
            }
        }

        protected override void ReadAsyncMethod(
            QueryBaseCommand source, 
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator
            )
        {
            MySqlConnectorQuery query = (MySqlConnectorQuery)source;
            if (query.SourceType.HasFlag(MySqlConnectorSourceType.MySqlConnection))
            {
                ReadMethodInner(
                    source,
                    MethodType.Async,
                    builder,
                    MySqlConnectorSourceType.MySqlConnection.ToTypeName(),
                    MySqlConnectorSourceType.MySqlConnection.ToParametrName(),
                    needCheckOpen: true,
                    interfaceGenerator
                    );
            }

            if (query.SourceType.HasFlag(MySqlConnectorSourceType.MySqlDataSource))
            {
                ReadMethodInner(
                    source,
                    MethodType.Async,
                    builder,
                    MySqlConnectorSourceType.MySqlDataSource.ToTypeName(),
                    MySqlConnectorSourceType.MySqlDataSource.ToParametrName(),
                    needCheckOpen: false,
                    interfaceGenerator
                    );
            }
        }
    }
}