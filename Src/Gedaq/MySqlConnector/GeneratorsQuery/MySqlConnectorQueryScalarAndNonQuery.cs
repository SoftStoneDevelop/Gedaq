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

        protected override void NonQueryMethod(QueryBaseCommand source, StringBuilder builder)
        {
            var query = (MySqlConnectorQuery)source;
            if (query.SourceType.HasFlag(MySqlConnectorSourceType.MySqlConnection))
            {
                NonQueryMethodDefinition(
                    source,
                    MethodType.Sync,
                    builder,
                    MySqlConnectorSourceType.MySqlConnection.ToTypeName(),
                    MySqlConnectorSourceType.MySqlConnection.ToParametrName(),
                    useInAndOut: true
                    );
                MethodBody(
                    source,
                    needCheckOpen: true,
                    MySqlConnectorSourceType.MySqlConnection.ToParametrName(),
                    MethodType.Sync,
                    QueryType.NonQuery,
                    builder
                    );
            }

            if (query.SourceType.HasFlag(MySqlConnectorSourceType.MySqlDataSource))
            {
                NonQueryMethodDefinition(
                    source,
                    MethodType.Sync,
                    builder,
                    MySqlConnectorSourceType.MySqlDataSource.ToTypeName(),
                    MySqlConnectorSourceType.MySqlDataSource.ToParametrName(),
                    useInAndOut: true
                    );
                MethodBody(
                    source,
                    needCheckOpen: false,
                    MySqlConnectorSourceType.MySqlDataSource.ToParametrName(),
                    MethodType.Sync,
                    QueryType.NonQuery,
                    builder
                    );
            }
        }

        protected override void NonQueryMethodAsync(QueryBaseCommand source, StringBuilder builder)
        {
            var query = (MySqlConnectorQuery)source;
            if (query.SourceType.HasFlag(MySqlConnectorSourceType.MySqlConnection))
            {
                NonQueryMethodDefinition(
                    source,
                    MethodType.Async,
                    builder,
                    MySqlConnectorSourceType.MySqlConnection.ToTypeName(),
                    MySqlConnectorSourceType.MySqlConnection.ToParametrName(),
                    useInAndOut: false
                    );
                MethodBody(
                    source,
                    needCheckOpen: true,
                    MySqlConnectorSourceType.MySqlConnection.ToParametrName(),
                    MethodType.Async,
                    QueryType.NonQuery,
                    builder
                    );
            }

            if (query.SourceType.HasFlag(MySqlConnectorSourceType.MySqlDataSource))
            {
                NonQueryMethodDefinition(
                    source,
                    MethodType.Async,
                    builder,
                    MySqlConnectorSourceType.MySqlDataSource.ToTypeName(),
                    MySqlConnectorSourceType.MySqlDataSource.ToParametrName(),
                    useInAndOut: false
                    );
                MethodBody(
                    source,
                    needCheckOpen: false,
                    MySqlConnectorSourceType.MySqlDataSource.ToParametrName(),
                    MethodType.Async,
                    QueryType.NonQuery,
                    builder
                    );
            }
        }

        protected override void ScalarMethod(QueryBaseCommand source, StringBuilder builder)
        {
            var query = (MySqlConnectorQuery)source;
            if (query.SourceType.HasFlag(MySqlConnectorSourceType.MySqlConnection))
            {
                ScalarMethodDefinition(
                    source,
                    MethodType.Sync,
                    builder,
                    MySqlConnectorSourceType.MySqlConnection.ToTypeName(),
                    MySqlConnectorSourceType.MySqlConnection.ToParametrName(),
                    useInAndOut: true
                    );
                MethodBody(
                    source,
                    needCheckOpen: true,
                    MySqlConnectorSourceType.MySqlConnection.ToParametrName(),
                    MethodType.Sync,
                    QueryType.Scalar,
                    builder
                    );
            }

            if (query.SourceType.HasFlag(MySqlConnectorSourceType.MySqlDataSource))
            {
                ScalarMethodDefinition(
                    source,
                    MethodType.Sync,
                    builder,
                    MySqlConnectorSourceType.MySqlDataSource.ToTypeName(),
                    MySqlConnectorSourceType.MySqlDataSource.ToParametrName(),
                    useInAndOut: true
                    );
                MethodBody(
                    source,
                    needCheckOpen: false,
                    MySqlConnectorSourceType.MySqlDataSource.ToParametrName(),
                    MethodType.Sync,
                    QueryType.Scalar,
                    builder
                    );
            }
        }

        protected override void ScalarMethodAsync(QueryBaseCommand source, StringBuilder builder)
        {
            var query = (MySqlConnectorQuery)source;
            if (query.SourceType.HasFlag(MySqlConnectorSourceType.MySqlConnection))
            {
                ScalarMethodDefinition(
                    source,
                    MethodType.Async,
                    builder,
                    MySqlConnectorSourceType.MySqlConnection.ToTypeName(),
                    MySqlConnectorSourceType.MySqlConnection.ToParametrName(),
                    useInAndOut: false
                    );
                MethodBody(
                    source,
                    needCheckOpen: true,
                    MySqlConnectorSourceType.MySqlConnection.ToParametrName(),
                    MethodType.Async,
                    QueryType.Scalar,
                    builder
                    );
            }

            if (query.SourceType.HasFlag(MySqlConnectorSourceType.MySqlDataSource))
            {
                ScalarMethodDefinition(
                    source,
                    MethodType.Async,
                    builder,
                    MySqlConnectorSourceType.MySqlDataSource.ToTypeName(),
                    MySqlConnectorSourceType.MySqlDataSource.ToParametrName(),
                    useInAndOut: false
                    );
                MethodBody(
                    source,
                    needCheckOpen: false,
                    MySqlConnectorSourceType.MySqlDataSource.ToParametrName(),
                    MethodType.Async,
                    QueryType.Scalar,
                    builder
                    );
            }
        }
    }
}