using Gedaq.Base;
using Gedaq.Base.Model;
using Gedaq.Base.Query;
using Gedaq.Enums;
using Gedaq.MySqlConnector.Enums;
using Gedaq.MySqlConnector.Helpers;
using Gedaq.MySqlConnector.Model;
using Gedaq.SqlClient;
using System.Text;

namespace Gedaq.MySqlConnector.GeneratorsQuery
{
    internal class MySqlConnectorQueryScalarAndNonQuery : QueryScalarNonQueryBase
    {
        private readonly MySqlConnectorProviderInfo _providerInfo = new MySqlConnectorProviderInfo();
        protected override ProviderInfo ProviderInfo => _providerInfo;

        protected override void NonQueryMethod(QueryBaseCommand source, StringBuilder builder)
        {
            var query = (MySqlConnectorQuery)source;
            if (query.SourceType.HasFlag(MySqlConnectorSourceType.MySqlConnection))
            {
                StartNonQueryMethod(
                    source, 
                    MethodType.Sync, 
                    builder
                    );
                QueryMethodParametrs(
                    source, 
                    MySqlConnectorSourceType.MySqlConnection.ToTypeName(), 
                    MySqlConnectorSourceType.MySqlConnection.ToParametrName(), 
                    builder,
                    true
                    );
                EndMethodParametrs(builder, MethodType.Sync);
                MethodBody(
                    source, 
                    true, 
                    MySqlConnectorSourceType.MySqlConnection.ToParametrName(), 
                    MethodType.Sync, 
                    QueryType.NonQuery, 
                    builder
                    );
                EndMethod(builder);
            }

            if (query.SourceType.HasFlag(MySqlConnectorSourceType.MySqlDataSource))
            {
                StartNonQueryMethod(source, MethodType.Sync, builder);
                QueryMethodParametrs(
                    source, 
                    MySqlConnectorSourceType.MySqlDataSource.ToTypeName(), 
                    MySqlConnectorSourceType.MySqlDataSource.ToParametrName(), 
                    builder,
                    true);
                EndMethodParametrs(builder, MethodType.Sync);
                MethodBody(
                    source, 
                    false, 
                    MySqlConnectorSourceType.MySqlDataSource.ToParametrName(), 
                    MethodType.Sync, 
                    QueryType.NonQuery, 
                    builder
                    );
                EndMethod(builder);
            }
        }

        protected override void NonQueryMethodAsync(QueryBaseCommand source, StringBuilder builder)
        {
            var query = (MySqlConnectorQuery)source;
            if (query.SourceType.HasFlag(MySqlConnectorSourceType.MySqlConnection))
            {
                StartNonQueryMethod(source, MethodType.Async, builder);
                QueryMethodParametrs(
                    source, 
                    MySqlConnectorSourceType.MySqlConnection.ToTypeName(), 
                    MySqlConnectorSourceType.MySqlConnection.ToParametrName(), 
                    builder,
                    false
                    );
                EndMethodParametrs(builder, MethodType.Async);
                MethodBody(
                    source, 
                    true, 
                    MySqlConnectorSourceType.MySqlConnection.ToParametrName(), 
                    MethodType.Async, 
                    QueryType.NonQuery, 
                    builder
                    );
                EndMethod(builder);
            }

            if (query.SourceType.HasFlag(MySqlConnectorSourceType.MySqlDataSource))
            {
                StartNonQueryMethod(source, MethodType.Async, builder);
                QueryMethodParametrs(
                    source, 
                    MySqlConnectorSourceType.MySqlDataSource.ToTypeName(), 
                    MySqlConnectorSourceType.MySqlDataSource.ToParametrName(), 
                    builder,
                    false
                    );
                EndMethodParametrs(builder, MethodType.Async);
                MethodBody(source, false, MySqlConnectorSourceType.MySqlDataSource.ToParametrName(), MethodType.Async, QueryType.NonQuery, builder);
                EndMethod(builder);
            }
        }

        protected override void ScalarMethod(QueryBaseCommand source, StringBuilder builder)
        {
            var query = (MySqlConnectorQuery)source;
            if (query.SourceType.HasFlag(MySqlConnectorSourceType.MySqlConnection))
            {
                StartScalarMethod(source, MethodType.Sync, builder);
                QueryMethodParametrs(
                    source, 
                    MySqlConnectorSourceType.MySqlConnection.ToTypeName(),
                    MySqlConnectorSourceType.MySqlConnection.ToParametrName(),
                    builder,
                    true
                    );
                EndMethodParametrs(builder, MethodType.Sync);
                MethodBody(
                    source, 
                    true, 
                    MySqlConnectorSourceType.MySqlConnection.ToParametrName(),
                    MethodType.Sync, 
                    QueryType.Scalar, 
                    builder
                    );
                EndMethod(builder);
            }

            if (query.SourceType.HasFlag(MySqlConnectorSourceType.MySqlDataSource))
            {
                StartScalarMethod(source, MethodType.Sync, builder);
                QueryMethodParametrs(
                    source, 
                    MySqlConnectorSourceType.MySqlDataSource.ToTypeName(),
                    MySqlConnectorSourceType.MySqlDataSource.ToParametrName(),
                    builder,
                    true
                    );
                EndMethodParametrs(builder, MethodType.Sync);
                MethodBody(
                    source, 
                    false, 
                    MySqlConnectorSourceType.MySqlDataSource.ToParametrName(), 
                    MethodType.Sync, 
                    QueryType.Scalar, 
                    builder
                    );
                EndMethod(builder);
            }
        }

        protected override void ScalarMethodAsync(QueryBaseCommand source, StringBuilder builder)
        {
            var query = (MySqlConnectorQuery)source;
            if (query.SourceType.HasFlag(MySqlConnectorSourceType.MySqlConnection))
            {
                StartScalarMethod(source, MethodType.Async, builder);
                QueryMethodParametrs(
                    source, MySqlConnectorSourceType.MySqlConnection.ToTypeName(), 
                    MySqlConnectorSourceType.MySqlConnection.ToParametrName(),
                    builder,
                    false
                    );
                EndMethodParametrs(builder, MethodType.Async);
                MethodBody(source, true, MySqlConnectorSourceType.MySqlConnection.ToParametrName(), MethodType.Async, QueryType.Scalar, builder);
                EndMethod(builder);
            }

            if (query.SourceType.HasFlag(MySqlConnectorSourceType.MySqlDataSource))
            {
                StartScalarMethod(source, MethodType.Async, builder);
                QueryMethodParametrs(
                    source, 
                    MySqlConnectorSourceType.MySqlDataSource.ToTypeName(), 
                    MySqlConnectorSourceType.MySqlDataSource.ToParametrName(),
                    builder,
                    false
                    );
                EndMethodParametrs(builder, MethodType.Async);
                MethodBody(
                    source, 
                    false, 
                    MySqlConnectorSourceType.MySqlDataSource.ToParametrName(),
                    MethodType.Async, 
                    QueryType.Scalar, 
                    builder
                    );
                EndMethod(builder);
            }
        }
    }
}