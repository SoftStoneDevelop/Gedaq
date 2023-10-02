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
    internal class MySqlConnectorQueryScalarAndNonQuery : QueryScalarNonQueryBase
    {
        private readonly MySqlConnectorProviderInfo _providerInfo = new MySqlConnectorProviderInfo();

        public MySqlConnectorQueryScalarAndNonQuery(MySqlConnectorCommand commandGenerator) : base(commandGenerator)
        {

        }

        protected override ProviderInfo ProviderInfo => _providerInfo;

        protected override void NonQueryMethod(
            QueryBaseCommand source, 
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator
            )
        {
            var query = (MySqlConnectorQuery)source;
            if (query.SourceType.HasFlag(MySqlConnectorSourceType.MySqlConnection))
            {
                NonQueryMethodInner(
                    source,
                    MethodType.Sync,
                    builder,
                    MySqlConnectorSourceType.MySqlConnection.ToTypeName(),
                    MySqlConnectorSourceType.MySqlConnection.ToParametrName(),
                    useInAndOut: true,
                    needCheckOpen: true,
                    interfaceGenerator
                    );
            }

            if (query.SourceType.HasFlag(MySqlConnectorSourceType.MySqlDataSource))
            {
                NonQueryMethodInner(
                    source,
                    MethodType.Sync,
                    builder,
                    MySqlConnectorSourceType.MySqlDataSource.ToTypeName(),
                    MySqlConnectorSourceType.MySqlDataSource.ToParametrName(),
                    useInAndOut: true,
                    needCheckOpen: false,
                    interfaceGenerator
                    );
            }
        }

        protected override void NonQueryMethodAsync(
            QueryBaseCommand source, 
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator
            )
        {
            var query = (MySqlConnectorQuery)source;
            if (query.SourceType.HasFlag(MySqlConnectorSourceType.MySqlConnection))
            {
                NonQueryMethodInner(
                    source,
                    MethodType.Async,
                    builder,
                    MySqlConnectorSourceType.MySqlConnection.ToTypeName(),
                    MySqlConnectorSourceType.MySqlConnection.ToParametrName(),
                    useInAndOut: false,
                    needCheckOpen: true,
                    interfaceGenerator
                    );
            }

            if (query.SourceType.HasFlag(MySqlConnectorSourceType.MySqlDataSource))
            {
                NonQueryMethodInner(
                    source,
                    MethodType.Async,
                    builder,
                    MySqlConnectorSourceType.MySqlDataSource.ToTypeName(),
                    MySqlConnectorSourceType.MySqlDataSource.ToParametrName(),
                    useInAndOut: false,
                    needCheckOpen: false,
                    interfaceGenerator
                    );
            }
        }

        protected override void ScalarMethod(
            QueryBaseCommand source, 
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator
            )
        {
            var query = (MySqlConnectorQuery)source;
            if (query.SourceType.HasFlag(MySqlConnectorSourceType.MySqlConnection))
            {
                ScalarMethodInner(
                    source,
                    MethodType.Sync,
                    builder,
                    MySqlConnectorSourceType.MySqlConnection.ToTypeName(),
                    MySqlConnectorSourceType.MySqlConnection.ToParametrName(),
                    useInAndOut: true,
                    needCheckOpen: true,
                    interfaceGenerator
                    );
            }

            if (query.SourceType.HasFlag(MySqlConnectorSourceType.MySqlDataSource))
            {
                ScalarMethodInner(
                    source,
                    MethodType.Sync,
                    builder,
                    MySqlConnectorSourceType.MySqlDataSource.ToTypeName(),
                    MySqlConnectorSourceType.MySqlDataSource.ToParametrName(),
                    useInAndOut: true,
                    needCheckOpen: false,
                    interfaceGenerator
                    );
            }
        }

        protected override void ScalarMethodAsync(
            QueryBaseCommand source, 
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator
            )
        {
            var query = (MySqlConnectorQuery)source;
            if (query.SourceType.HasFlag(MySqlConnectorSourceType.MySqlConnection))
            {
                ScalarMethodInner(
                    source,
                    MethodType.Async,
                    builder,
                    MySqlConnectorSourceType.MySqlConnection.ToTypeName(),
                    MySqlConnectorSourceType.MySqlConnection.ToParametrName(),
                    useInAndOut: false,
                    needCheckOpen: true,
                    interfaceGenerator
                    );
            }

            if (query.SourceType.HasFlag(MySqlConnectorSourceType.MySqlDataSource))
            {
                ScalarMethodInner(
                    source,
                    MethodType.Async,
                    builder,
                    MySqlConnectorSourceType.MySqlDataSource.ToTypeName(),
                    MySqlConnectorSourceType.MySqlDataSource.ToParametrName(),
                    useInAndOut: false,
                    needCheckOpen: false,
                    interfaceGenerator
                    );
            }
        }
    }
}