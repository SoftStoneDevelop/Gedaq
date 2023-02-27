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
        private readonly MySqlConnectorQueryCommon _queryCommon = new MySqlConnectorQueryCommon();
        protected override QueryCommonBase QueryCommon => _queryCommon;

        protected override void NonQueryMethod(QueryBase source, StringBuilder builder)
        {
            var query = (MySqlConnectorQuery)source;
            if (query.SourceType.HasFlag(MySqlConnectorSourceType.MySqlConnection))
            {
                StartNonQueryMethod(source, MethodType.Sync, builder);
                QueryMethodParametrs(source, MySqlConnectorSourceType.MySqlConnection.ToTypeName(), MySqlConnectorSourceType.MySqlConnection.ToParametrName(), builder);
                EndMethodParametrs(builder);
                MethodBody(source, true, MySqlConnectorSourceType.MySqlConnection.ToParametrName(), MethodType.Sync, QueryType.NonQuery, builder);
                EndMethod(builder);
            }

            if (query.SourceType.HasFlag(MySqlConnectorSourceType.MySqlDataSource))
            {
                StartNonQueryMethod(source, MethodType.Sync, builder);
                QueryMethodParametrs(source, MySqlConnectorSourceType.MySqlDataSource.ToTypeName(), MySqlConnectorSourceType.MySqlDataSource.ToParametrName(), builder);
                EndMethodParametrs(builder);
                MethodBody(source, false, MySqlConnectorSourceType.MySqlDataSource.ToParametrName(), MethodType.Sync, QueryType.NonQuery, builder);
                EndMethod(builder);
            }
        }

        protected override void NonQueryMethodAsync(QueryBase source, StringBuilder builder)
        {
            var query = (MySqlConnectorQuery)source;
            if (query.SourceType.HasFlag(MySqlConnectorSourceType.MySqlConnection))
            {
                StartNonQueryMethod(source, MethodType.Async, builder);
                QueryMethodParametrs(source, MySqlConnectorSourceType.MySqlConnection.ToTypeName(), MySqlConnectorSourceType.MySqlConnection.ToParametrName(), builder);
                AsyncEndMethodParametrs(builder);
                MethodBody(source, true, MySqlConnectorSourceType.MySqlConnection.ToParametrName(), MethodType.Async, QueryType.NonQuery, builder);
                EndMethod(builder);
            }

            if (query.SourceType.HasFlag(MySqlConnectorSourceType.MySqlDataSource))
            {
                StartNonQueryMethod(source, MethodType.Async, builder);
                QueryMethodParametrs(source, MySqlConnectorSourceType.MySqlDataSource.ToTypeName(), MySqlConnectorSourceType.MySqlDataSource.ToParametrName(), builder);
                AsyncEndMethodParametrs(builder);
                MethodBody(source, false, MySqlConnectorSourceType.MySqlDataSource.ToParametrName(), MethodType.Async, QueryType.NonQuery, builder);
                EndMethod(builder);
            }
        }

        protected override void ScalarMethod(QueryBase source, StringBuilder builder)
        {
            var query = (MySqlConnectorQuery)source;
            if (query.SourceType.HasFlag(MySqlConnectorSourceType.MySqlConnection))
            {
                StartScalarMethod(source, MethodType.Sync, builder);
                QueryMethodParametrs(source, MySqlConnectorSourceType.MySqlConnection.ToTypeName(), MySqlConnectorSourceType.MySqlConnection.ToParametrName(), builder);
                EndMethodParametrs(builder);
                MethodBody(source, true, MySqlConnectorSourceType.MySqlConnection.ToParametrName(), MethodType.Sync, QueryType.Scalar, builder);
                EndMethod(builder);
            }

            if (query.SourceType.HasFlag(MySqlConnectorSourceType.MySqlDataSource))
            {
                StartScalarMethod(source, MethodType.Sync, builder);
                QueryMethodParametrs(source, MySqlConnectorSourceType.MySqlDataSource.ToTypeName(), MySqlConnectorSourceType.MySqlDataSource.ToParametrName(), builder);
                EndMethodParametrs(builder);
                MethodBody(source, false, MySqlConnectorSourceType.MySqlDataSource.ToParametrName(), MethodType.Sync, QueryType.Scalar, builder);
                EndMethod(builder);
            }
        }

        protected override void ScalarMethodAsync(QueryBase source, StringBuilder builder)
        {
            var query = (MySqlConnectorQuery)source;
            if (query.SourceType.HasFlag(MySqlConnectorSourceType.MySqlConnection))
            {
                StartScalarMethod(source, MethodType.Async, builder);
                QueryMethodParametrs(source, MySqlConnectorSourceType.MySqlConnection.ToTypeName(), MySqlConnectorSourceType.MySqlConnection.ToParametrName(), builder);
                AsyncEndMethodParametrs(builder);
                MethodBody(source, true, MySqlConnectorSourceType.MySqlConnection.ToParametrName(), MethodType.Async, QueryType.Scalar, builder);
                EndMethod(builder);
            }

            if (query.SourceType.HasFlag(MySqlConnectorSourceType.MySqlDataSource))
            {
                StartScalarMethod(source, MethodType.Async, builder);
                QueryMethodParametrs(source, MySqlConnectorSourceType.MySqlDataSource.ToTypeName(), MySqlConnectorSourceType.MySqlDataSource.ToParametrName(), builder);
                AsyncEndMethodParametrs(builder);
                MethodBody(source, false, MySqlConnectorSourceType.MySqlDataSource.ToParametrName(), MethodType.Async, QueryType.Scalar, builder);
                EndMethod(builder);
            }
        }
    }
}