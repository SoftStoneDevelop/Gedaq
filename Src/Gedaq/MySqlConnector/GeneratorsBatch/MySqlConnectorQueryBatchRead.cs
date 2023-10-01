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
                StartReadMethod(source, MethodType.Sync, builder);
                StartMethodParametrs(source, MySqlConnectorSourceType.MySqlConnection.ToTypeName(), MySqlConnectorSourceType.MySqlConnection.ToParametrName(), builder);
                EndMethodParametrs(builder, MethodType.Sync);
                ReadMethodBody(source, true, MySqlConnectorSourceType.MySqlConnection.ToParametrName(), MethodType.Sync, builder);
                EndMethod(builder);
            }

            if (batch.SourceType.HasFlag(MySqlConnectorSourceType.MySqlDataSource))
            {
                StartReadMethod(source, MethodType.Sync, builder);
                StartMethodParametrs(source, MySqlConnectorSourceType.MySqlDataSource.ToTypeName(), MySqlConnectorSourceType.MySqlDataSource.ToParametrName(), builder);
                EndMethodParametrs(builder, MethodType.Sync);
                ReadMethodBody(source, false, MySqlConnectorSourceType.MySqlDataSource.ToParametrName(), MethodType.Sync, builder);
                EndMethod(builder);
            }
        }

        protected override void ReadAsyncMethod(QueryBatchCommand source, StringBuilder builder)
        {
            var batch = (MySqlConnectorQueryBatch)source;
            if (batch.SourceType.HasFlag(MySqlConnectorSourceType.MySqlConnection))
            {
                StartReadMethod(source, MethodType.Async, builder);
                StartMethodParametrs(source, MySqlConnectorSourceType.MySqlConnection.ToTypeName(), MySqlConnectorSourceType.MySqlConnection.ToParametrName(), builder);
                EndMethodParametrs(builder, MethodType.Async);
                ReadMethodBody(source, true, MySqlConnectorSourceType.MySqlConnection.ToParametrName(), MethodType.Async, builder);
                EndMethod(builder);
            }

            if (batch.SourceType.HasFlag(MySqlConnectorSourceType.MySqlDataSource))
            {
                StartReadMethod(source, MethodType.Async, builder);
                StartMethodParametrs(source, MySqlConnectorSourceType.MySqlDataSource.ToTypeName(), MySqlConnectorSourceType.MySqlDataSource.ToParametrName(), builder);
                EndMethodParametrs(builder, MethodType.Async);
                ReadMethodBody(source, false, MySqlConnectorSourceType.MySqlDataSource.ToParametrName(), MethodType.Sync, builder);
                EndMethod(builder);
            }
        }
    }
}