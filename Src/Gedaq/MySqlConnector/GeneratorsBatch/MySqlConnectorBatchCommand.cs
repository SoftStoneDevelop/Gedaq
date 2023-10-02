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
    internal class MySqlConnectorBatchCommand : BatchCommandBase
    {
        private readonly MySqlConnectorProviderInfo _providerInfo = new MySqlConnectorProviderInfo();
        protected override ProviderInfo ProviderInfo => _providerInfo;

        protected override void CreateBatchMethods(
            QueryBatchCommand source, 
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator
            )
        {
            var npgsqlBatch = (MySqlConnectorQueryBatch)source;
            if (source.MethodType.HasFlag(MethodType.Sync))
            {
                if (npgsqlBatch.SourceType.HasFlag(MySqlConnectorSourceType.MySqlConnection))
                {
                    CreateBatchMethodDefinition(
                        source, 
                        MySqlConnectorSourceType.MySqlConnection.ToTypeName(), 
                        MySqlConnectorSourceType.MySqlConnection.ToParametrName(), 
                        MethodType.Sync, 
                        builder
                        );
                    if(source.AsPartInterface)
                    {
                        CreateBatchMethodDefinition(
                            source,
                            MySqlConnectorSourceType.MySqlConnection.ToTypeName(),
                            MySqlConnectorSourceType.MySqlConnection.ToParametrName(),
                            MethodType.Sync,
                            interfaceGenerator.DefinitionBuilder(),
                            forInterface: true
                            );
                        interfaceGenerator.AddMethodDefinition();
                    }
                    CreateBatchMethodBody(
                        source, 
                        MySqlConnectorSourceType.MySqlConnection.ToParametrName(), 
                        MethodType.Sync, 
                        builder
                        );
                }

                if (npgsqlBatch.SourceType.HasFlag(MySqlConnectorSourceType.MySqlDataSource))
                {
                    CreateBatchMethodDefinition(
                        source, 
                        MySqlConnectorSourceType.MySqlDataSource.ToTypeName(), 
                        MySqlConnectorSourceType.MySqlDataSource.ToParametrName(), 
                        MethodType.Sync, 
                        builder
                        );
                    if(source.AsPartInterface)
                    {
                        CreateBatchMethodDefinition(
                            source,
                            MySqlConnectorSourceType.MySqlDataSource.ToTypeName(),
                            MySqlConnectorSourceType.MySqlDataSource.ToParametrName(),
                            MethodType.Sync,
                            interfaceGenerator.DefinitionBuilder(),
                            forInterface: true
                            );
                        interfaceGenerator.AddMethodDefinition();
                    }
                    CreateBatchMethodBody(
                        source,
                        MySqlConnectorSourceType.MySqlDataSource.ToParametrName(),
                        MethodType.Sync,
                        builder
                        );
                }
            }

            if (source.MethodType.HasFlag(MethodType.Async))
            {
                if (npgsqlBatch.SourceType.HasFlag(MySqlConnectorSourceType.MySqlConnection))
                {
                    CreateBatchMethodDefinition(
                        source, 
                        MySqlConnectorSourceType.MySqlConnection.ToTypeName(), 
                        MySqlConnectorSourceType.MySqlConnection.ToParametrName(), 
                        MethodType.Async, 
                        builder
                        );
                    if(source.AsPartInterface)
                    {
                        CreateBatchMethodDefinition(
                            source,
                            MySqlConnectorSourceType.MySqlConnection.ToTypeName(),
                            MySqlConnectorSourceType.MySqlConnection.ToParametrName(),
                            MethodType.Async,
                            interfaceGenerator.DefinitionBuilder(),
                            forInterface: true
                            );
                        interfaceGenerator.AddMethodDefinition();
                    }
                    CreateBatchMethodBody(
                        source,
                        MySqlConnectorSourceType.MySqlConnection.ToParametrName(),
                        MethodType.Async,
                        builder
                        );
                }

                if (npgsqlBatch.SourceType.HasFlag(MySqlConnectorSourceType.MySqlDataSource))
                {
                    CreateBatchMethodDefinition(
                        source,
                        MySqlConnectorSourceType.MySqlDataSource.ToTypeName(), 
                        MySqlConnectorSourceType.MySqlDataSource.ToParametrName(), 
                        MethodType.Async, 
                        builder
                        );
                    if(source.AsPartInterface)
                    {
                        CreateBatchMethodDefinition(
                            source,
                            MySqlConnectorSourceType.MySqlDataSource.ToTypeName(),
                            MySqlConnectorSourceType.MySqlDataSource.ToParametrName(),
                            MethodType.Async,
                            interfaceGenerator.DefinitionBuilder(),
                            forInterface: true
                            );
                        interfaceGenerator.AddMethodDefinition();
                    }
                    CreateBatchMethodBody(
                        source,
                        MySqlConnectorSourceType.MySqlDataSource.ToParametrName(),
                        MethodType.Async,
                        builder
                        );
                }
            }

            SetParametrsMethodDefinition(source, builder);
            if(source.AsPartInterface)
            {
                SetParametrsMethodDefinition(source, interfaceGenerator.DefinitionBuilder(), forInterface: true);
                interfaceGenerator.AddMethodDefinition();
            }
            SetParametrsMethodBody(source, builder);
        }

        protected override void CreateParametr(BaseParametr baseParametr, StringBuilder builder)
        {
            builder.Append($@"
                {{");
            MySqlConnectorGeneratorHelper.CreateParametr(baseParametr, builder);
            builder.Append($@"
                }}");
        }
    }
}