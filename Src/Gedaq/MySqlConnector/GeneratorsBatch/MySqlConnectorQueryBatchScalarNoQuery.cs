using Gedaq.Base;
using Gedaq.Base.Batch;
using Gedaq.Base.Model;
using Gedaq.Enums;
using Gedaq.MySqlConnector.Enums;
using Gedaq.MySqlConnector.Helpers;
using Gedaq.MySqlConnector.Model;
using System.Text;

namespace Gedaq.MySqlConnector.GeneratorsBatch
{
    internal class MySqlConnectorQueryBatchScalarNoQuery : QueryBatchScalarNoQueryBase
    {
        MySqlConnectorProviderInfo _providerInfo = new MySqlConnectorProviderInfo();

        public MySqlConnectorQueryBatchScalarNoQuery(MySqlConnectorBatchCommand commandGenerator) : base(commandGenerator)
        {

        }

        protected override ProviderInfo ProviderInfo => _providerInfo;

        protected override void ScalarMethod(QueryBatchCommand source, StringBuilder builder)
        {
            var batch = (MySqlConnectorQueryBatch)source;
            if (batch.SourceType.HasFlag(MySqlConnectorSourceType.MySqlConnection))
            {
                ScalarMethodDefinition(
                    source,
                    MethodType.Sync,
                    MySqlConnectorSourceType.MySqlConnection.ToTypeName(),
                    MySqlConnectorSourceType.MySqlConnection.ToParametrName(),
                    builder
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

            if (batch.SourceType.HasFlag(MySqlConnectorSourceType.MySqlDataSource))
            {
                ScalarMethodDefinition(
                    source,
                    MethodType.Sync,
                    MySqlConnectorSourceType.MySqlDataSource.ToTypeName(),
                    MySqlConnectorSourceType.MySqlDataSource.ToParametrName(),
                    builder
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

        protected override void ScalarMethodAsync(QueryBatchCommand source, StringBuilder builder)
        {
            var batch = (MySqlConnectorQueryBatch)source;
            if (batch.SourceType.HasFlag(MySqlConnectorSourceType.MySqlConnection))
            {
                ScalarMethodDefinition(
                    source,
                    MethodType.Async,
                    MySqlConnectorSourceType.MySqlConnection.ToTypeName(),
                    MySqlConnectorSourceType.MySqlConnection.ToParametrName(),
                    builder
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

            if (batch.SourceType.HasFlag(MySqlConnectorSourceType.MySqlDataSource))
            {
                ScalarMethodDefinition(
                    source,
                    MethodType.Async,
                    MySqlConnectorSourceType.MySqlDataSource.ToTypeName(),
                    MySqlConnectorSourceType.MySqlDataSource.ToParametrName(),
                    builder
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

        protected override void NonQueryMethod(QueryBatchCommand source, StringBuilder builder)
        {
            var batch = (MySqlConnectorQueryBatch)source;
            if (batch.SourceType.HasFlag(MySqlConnectorSourceType.MySqlConnection))
            {
                NonQueryMethodDefinition(
                    source,
                    MethodType.Sync,
                    MySqlConnectorSourceType.MySqlConnection.ToTypeName(), 
                    MySqlConnectorSourceType.MySqlConnection.ToParametrName(),
                    builder
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

            if (batch.SourceType.HasFlag(MySqlConnectorSourceType.MySqlDataSource))
            {
                NonQueryMethodDefinition(
                    source,
                    MethodType.Sync,
                    MySqlConnectorSourceType.MySqlDataSource.ToTypeName(),
                    MySqlConnectorSourceType.MySqlDataSource.ToParametrName(),
                    builder
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

        protected override void NonQueryMethodAsync(QueryBatchCommand source, StringBuilder builder)
        {
            var batch = (MySqlConnectorQueryBatch)source;
            if (batch.SourceType.HasFlag(MySqlConnectorSourceType.MySqlConnection))
            {
                NonQueryMethodDefinition(
                    source,
                    MethodType.Sync,
                    MySqlConnectorSourceType.MySqlDataSource.ToTypeName(),
                    MySqlConnectorSourceType.MySqlDataSource.ToParametrName(),
                    builder
                    );
                MethodBody(
                    source,
                    needCheckOpen: true,
                    MySqlConnectorSourceType.MySqlDataSource.ToParametrName(),
                    MethodType.Sync,
                    QueryType.NonQuery,
                    builder
                    );
            }

            if (batch.SourceType.HasFlag(MySqlConnectorSourceType.MySqlDataSource))
            {
                NonQueryMethodDefinition(
                    source,
                    MethodType.Async,
                    MySqlConnectorSourceType.MySqlDataSource.ToTypeName(),
                    MySqlConnectorSourceType.MySqlDataSource.ToParametrName(),
                    builder
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
    }
}