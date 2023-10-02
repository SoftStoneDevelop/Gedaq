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

        protected override void ReadMethod(
            QueryBatchCommand source, 
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator
            )
        {
            var batch = (MySqlConnectorQueryBatch)source;
            if (batch.SourceType.HasFlag(MySqlConnectorSourceType.MySqlConnection))
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

            if (batch.SourceType.HasFlag(MySqlConnectorSourceType.MySqlDataSource))
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
            QueryBatchCommand source, 
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator
            )
        {
            var batch = (MySqlConnectorQueryBatch)source;
            if (batch.SourceType.HasFlag(MySqlConnectorSourceType.MySqlConnection))
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

            if (batch.SourceType.HasFlag(MySqlConnectorSourceType.MySqlDataSource))
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