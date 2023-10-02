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

        protected override void ScalarMethod(
            QueryBatchCommand source, 
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator
            )
        {
            var batch = (MySqlConnectorQueryBatch)source;
            if (batch.SourceType.HasFlag(MySqlConnectorSourceType.MySqlConnection))
            {
                ScalarMethodInner(
                    source,
                    MethodType.Sync,
                    MySqlConnectorSourceType.MySqlConnection.ToTypeName(),
                    MySqlConnectorSourceType.MySqlConnection.ToParametrName(),
                    builder,
                    needCheckOpen: true,
                    interfaceGenerator
                    );
            }

            if (batch.SourceType.HasFlag(MySqlConnectorSourceType.MySqlDataSource))
            {
                ScalarMethodInner(
                    source,
                    MethodType.Sync,
                    MySqlConnectorSourceType.MySqlDataSource.ToTypeName(),
                    MySqlConnectorSourceType.MySqlDataSource.ToParametrName(),
                    builder,
                    needCheckOpen: false,
                    interfaceGenerator
                    );
            }
        }

        protected override void ScalarMethodAsync(
            QueryBatchCommand source, 
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator
            )
        {
            var batch = (MySqlConnectorQueryBatch)source;
            if (batch.SourceType.HasFlag(MySqlConnectorSourceType.MySqlConnection))
            {
                ScalarMethodInner(
                    source,
                    MethodType.Async,
                    MySqlConnectorSourceType.MySqlConnection.ToTypeName(),
                    MySqlConnectorSourceType.MySqlConnection.ToParametrName(),
                    builder,
                    needCheckOpen: true,
                    interfaceGenerator
                    );
            }

            if (batch.SourceType.HasFlag(MySqlConnectorSourceType.MySqlDataSource))
            {
                ScalarMethodInner(
                    source,
                    MethodType.Async,
                    MySqlConnectorSourceType.MySqlDataSource.ToTypeName(),
                    MySqlConnectorSourceType.MySqlDataSource.ToParametrName(),
                    builder,
                    needCheckOpen: false,
                    interfaceGenerator
                    );
            }
        }

        protected override void NonQueryMethod(
            QueryBatchCommand source, 
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator
            )
        {
            var batch = (MySqlConnectorQueryBatch)source;
            if (batch.SourceType.HasFlag(MySqlConnectorSourceType.MySqlConnection))
            {
                NonQueryMethodInner(
                    source, 
                    MethodType.Sync, 
                    MySqlConnectorSourceType.MySqlConnection.ToTypeName(),
                    MySqlConnectorSourceType.MySqlConnection.ToParametrName(), 
                    builder, 
                    needCheckOpen: true, 
                    interfaceGenerator
                    );
            }

            if (batch.SourceType.HasFlag(MySqlConnectorSourceType.MySqlDataSource))
            {
                NonQueryMethodInner(
                    source,
                    MethodType.Sync,
                    MySqlConnectorSourceType.MySqlDataSource.ToTypeName(),
                    MySqlConnectorSourceType.MySqlDataSource.ToParametrName(),
                    builder,
                    needCheckOpen: false,
                    interfaceGenerator
                    );
            }
        }

        protected override void NonQueryMethodAsync(
            QueryBatchCommand source, 
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator
            )
        {
            var batch = (MySqlConnectorQueryBatch)source;
            if (batch.SourceType.HasFlag(MySqlConnectorSourceType.MySqlConnection))
            {
                NonQueryMethodInner(
                    source,
                    MethodType.Async,
                    MySqlConnectorSourceType.MySqlConnection.ToTypeName(),
                    MySqlConnectorSourceType.MySqlConnection.ToParametrName(),
                    builder,
                    needCheckOpen: true,
                    interfaceGenerator
                    );
            }

            if (batch.SourceType.HasFlag(MySqlConnectorSourceType.MySqlDataSource))
            {
                NonQueryMethodInner(
                    source,
                    MethodType.Async,
                    MySqlConnectorSourceType.MySqlDataSource.ToTypeName(),
                    MySqlConnectorSourceType.MySqlDataSource.ToParametrName(),
                    builder,
                    needCheckOpen: false,
                    interfaceGenerator
                    );
            }
        }
    }
}