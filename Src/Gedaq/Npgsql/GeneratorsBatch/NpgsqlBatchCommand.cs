using Gedaq.Base;
using Gedaq.Base.Batch;
using Gedaq.Base.Model;
using Gedaq.Enums;
using Gedaq.Npgsql.Helpers;
using Gedaq.Npgsql.Model;
using System.Text;

namespace Gedaq.Npgsql.GeneratorsBatch
{
    internal class NpgsqlBatchCommand : BatchCommandBase
    {
        private readonly NpgsqlProviderInfo _providerInfo = new NpgsqlProviderInfo();
        protected override ProviderInfo ProviderInfo => _providerInfo;

        protected override void CreateBatchMethods(
            QueryBatchCommand source, 
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator
            )
        {
            var batch = (NpgsqlQueryBatch)source;
            if (source.MethodType.HasFlag(MethodType.Sync))
            {
                if (batch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
                {
                    CreateBatchMethodInner(
                        source, 
                        Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(), 
                        Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(), 
                        MethodType.Sync, 
                        builder,
                        interfaceGenerator
                        );
                }

                if (batch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
                {
                    CreateBatchMethodInner(
                        source,
                        Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(),
                        Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(),
                        MethodType.Sync,
                        builder,
                        interfaceGenerator
                        );
                }
            }

            if (source.MethodType.HasFlag(MethodType.Async))
            {
                if (batch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
                {
                    CreateBatchMethodInner(
                        source,
                        Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(),
                        Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(),
                        MethodType.Async,
                        builder,
                        interfaceGenerator
                        );
                }

                if (batch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
                {
                    CreateBatchMethodInner(
                        source,
                        Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(),
                        Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(),
                        MethodType.Async,
                        builder,
                        interfaceGenerator
                        );
                }
            }

            SetParametrsMethodInner(source, builder, interfaceGenerator);
        }

        protected override void CreateParametr(BaseParametr baseParametr, StringBuilder builder)
        {
            builder.Append($@"
                {{");
            NpgsqlGeneratorHelper.CreateParametr(baseParametr, builder);
            builder.Append($@"
                }}");
        }
    }
}