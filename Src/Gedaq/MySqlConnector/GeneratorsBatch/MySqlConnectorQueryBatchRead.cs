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
    internal class MySqlConnectorQueryBatchRead : QueryBatchReadBase
    {
        MySqlConnectorProviderInfo _providerInfo = new MySqlConnectorProviderInfo();

        public MySqlConnectorQueryBatchRead(MySqlConnectorBatchCommand commandGenerator) : base(commandGenerator)
        {

        }

        protected override ProviderInfo ProviderInfo => _providerInfo;

        protected override void ReadMethod(QueryBatchCommand source, StringBuilder builder)
        {
            var batch = (MySqlConnectorQueryBatch)source;
            if (batch.SourceType.HasFlag(MySqlConnectorSourceType.MySqlConnection))
            {
                ReadMethodDefinition(
                    source,
                    MethodType.Sync,
                    builder,
                    MySqlConnectorSourceType.MySqlConnection.ToTypeName(),
                    MySqlConnectorSourceType.MySqlConnection.ToParametrName()
                    );
                ReadMethodBody(
                    source,
                    true,
                    MySqlConnectorSourceType.MySqlConnection.ToParametrName(),
                    MethodType.Sync,
                    builder
                    );
            }

            if (batch.SourceType.HasFlag(MySqlConnectorSourceType.MySqlDataSource))
            {
                ReadMethodDefinition(
                    source,
                    MethodType.Sync,
                    builder,
                    MySqlConnectorSourceType.MySqlDataSource.ToTypeName(),
                    MySqlConnectorSourceType.MySqlDataSource.ToParametrName()
                    );
                ReadMethodBody(
                    source,
                    true,
                    MySqlConnectorSourceType.MySqlDataSource.ToParametrName(),
                    MethodType.Sync,
                    builder
                    );
            }
        }

        protected override void ReadAsyncMethod(QueryBatchCommand source, StringBuilder builder)
        {
            var batch = (MySqlConnectorQueryBatch)source;
            if (batch.SourceType.HasFlag(MySqlConnectorSourceType.MySqlConnection))
            {
                ReadMethodDefinition(
                    source,
                    MethodType.Async,
                    builder,
                    MySqlConnectorSourceType.MySqlConnection.ToTypeName(),
                    MySqlConnectorSourceType.MySqlConnection.ToParametrName()
                    );
                ReadMethodBody(
                    source,
                    true,
                    MySqlConnectorSourceType.MySqlConnection.ToParametrName(),
                    MethodType.Async,
                    builder
                    );
            }

            if (batch.SourceType.HasFlag(MySqlConnectorSourceType.MySqlDataSource))
            {
                ReadMethodDefinition(
                    source,
                    MethodType.Async,
                    builder,
                    MySqlConnectorSourceType.MySqlDataSource.ToTypeName(),
                    MySqlConnectorSourceType.MySqlDataSource.ToParametrName()
                    );
                ReadMethodBody(
                    source,
                    true,
                    MySqlConnectorSourceType.MySqlDataSource.ToParametrName(),
                    MethodType.Async,
                    builder
                    );
            }
        }
    }
}