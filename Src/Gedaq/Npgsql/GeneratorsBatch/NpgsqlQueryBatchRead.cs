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

        protected override void ReadMethod(QueryBatchCommand source, StringBuilder builder)
        {
            var batch = (NpgsqlQueryBatch)source;
            if (batch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                ReadMethodDefinition(
                    source,
                    MethodType.Sync,
                    builder,
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(), 
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName()
                    );
                ReadMethodBody(
                    source,
                    needCheckOpen: true,
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(),
                    MethodType.Sync,
                    builder
                    );
            }

            if (batch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                ReadMethodDefinition(
                    source,
                    MethodType.Sync,
                    builder,
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName()
                    );
                ReadMethodBody(
                    source,
                    needCheckOpen: false,
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(),
                    MethodType.Sync,
                    builder
                    );
            }
        }

        protected override void ReadAsyncMethod(QueryBatchCommand source, StringBuilder builder)
        {
            var batch = (NpgsqlQueryBatch)source;
            if (batch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                ReadMethodDefinition(
                    source,
                    MethodType.Async,
                    builder,
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName()
                    );
                ReadMethodBody(
                    source,
                    needCheckOpen: true,
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(),
                    MethodType.Async,
                    builder
                    );
            }

            if (batch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                ReadMethodDefinition(
                    source,
                    MethodType.Async,
                    builder,
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName()
                    );
                ReadMethodBody(
                    source,
                    needCheckOpen: false,
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(),
                    MethodType.Async,
                    builder
                    );
            }
        }
    }
}