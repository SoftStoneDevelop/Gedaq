using Gedaq.Base;
using Gedaq.Base.Batch;
using Gedaq.Base.Model;
using Gedaq.Enums;
using Gedaq.Npgsql.Helpers;
using Gedaq.Npgsql.Model;
using System.Text;

namespace Gedaq.Npgsql.GeneratorsBatch
{
    internal class NpgsqlQueryBatchRead : QueryBatchReadBase
    {
        NpgsqlProviderInfo _providerInfo = new NpgsqlProviderInfo();

        public NpgsqlQueryBatchRead(NpgsqlBatchCommand commandGenerator) : base(commandGenerator)
        {

        }

        protected override ProviderInfo ProviderInfo => _providerInfo;

        protected override void ReadMethod(
            QueryBatchCommand source, 
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator
            )
        {
            var batch = (NpgsqlQueryBatch)source;
            if (batch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                ReadMethodInner(
                    source,
                    MethodType.Sync,
                    builder,
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(), 
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(),
                    needCheckOpen: true,
                    interfaceGenerator
                    );
            }

            if (batch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                ReadMethodInner(
                    source,
                    MethodType.Sync,
                    builder,
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(),
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
            var batch = (NpgsqlQueryBatch)source;
            if (batch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                ReadMethodInner(
                    source,
                    MethodType.Async,
                    builder,
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(),
                    needCheckOpen: true,
                    interfaceGenerator
                    );
            }

            if (batch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                ReadMethodInner(
                    source,
                    MethodType.Async,
                    builder,
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(),
                    needCheckOpen: false,
                    interfaceGenerator
                    );
            }
        }
    }
}