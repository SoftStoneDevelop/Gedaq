using Gedaq.Base;
using Gedaq.Base.Batch;
using Gedaq.Base.Model;
using Gedaq.Enums;
using Gedaq.Npgsql.Helpers;
using Gedaq.Npgsql.Model;
using System.Text;

namespace Gedaq.Npgsql.GeneratorsBatch
{
    internal class NpgsqlQueryBatchScalarNoQuery : QueryBatchScalarNoQueryBase
    {
        NpgsqlProviderInfo _providerInfo = new NpgsqlProviderInfo();

        public NpgsqlQueryBatchScalarNoQuery(NpgsqlBatchCommand commandGenerator) : base(commandGenerator)
        {

        }

        protected override ProviderInfo ProviderInfo => _providerInfo;

        protected override void ScalarMethod(QueryBatchCommand source, StringBuilder builder)
        {
            var batch = (NpgsqlQueryBatch)source;
            if (batch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                ScalarMethodDefinition(
                    source,
                    MethodType.Sync,
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(), 
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(),
                    builder
                    );
                MethodBody(
                    source,
                    needCheckOpen: true,
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(),
                    MethodType.Sync,
                    QueryType.Scalar,
                    builder
                    );
            }

            if (batch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                ScalarMethodDefinition(
                    source,
                    MethodType.Sync,
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(),
                    builder
                    );
                MethodBody(
                    source,
                    needCheckOpen: false,
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(),
                    MethodType.Sync,
                    QueryType.Scalar,
                    builder
                    );
            }
        }

        protected override void ScalarMethodAsync(QueryBatchCommand source, StringBuilder builder)
        {
            var batch = (NpgsqlQueryBatch)source;
            if (batch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                ScalarMethodDefinition(
                    source,
                    MethodType.Async,
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(),
                    builder
                    );
                MethodBody(
                    source,
                    needCheckOpen: true,
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(),
                    MethodType.Async,
                    QueryType.Scalar,
                    builder
                    );
            }

            if (batch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                ScalarMethodDefinition(
                    source,
                    MethodType.Async,
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(),
                    builder
                    );
                MethodBody(
                    source,
                    needCheckOpen: false,
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(),
                    MethodType.Async,
                    QueryType.Scalar,
                    builder
                    );
            }
        }

        protected override void NonQueryMethod(QueryBatchCommand source, StringBuilder builder)
        {
            var batch = (NpgsqlQueryBatch)source;
            if (batch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                NonQueryMethodDefinition(
                    source,
                    MethodType.Sync,
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(), 
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(),
                    builder
                    );
                MethodBody(
                    source,
                    needCheckOpen: true,
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(),
                    MethodType.Sync,
                    QueryType.NonQuery,
                    builder
                    );
            }

            if (batch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                NonQueryMethodDefinition(
                    source,
                    MethodType.Sync,
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(),
                    builder
                    );
                MethodBody(
                    source,
                    needCheckOpen: false,
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(),
                    MethodType.Sync,
                    QueryType.NonQuery,
                    builder
                    );
            }
        }

        protected override void NonQueryMethodAsync(QueryBatchCommand source, StringBuilder builder)
        {
            var batch = (NpgsqlQueryBatch)source;
            if (batch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                NonQueryMethodDefinition(
                    source,
                    MethodType.Async,
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(),
                    builder
                    );
                MethodBody(
                    source,
                    needCheckOpen: true,
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(),
                    MethodType.Async,
                    QueryType.NonQuery,
                    builder
                    );
            }

            if (batch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                NonQueryMethodDefinition(
                    source,
                    MethodType.Async,
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(),
                    builder
                    );
                MethodBody(
                    source,
                    needCheckOpen: false,
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(),
                    MethodType.Async,
                    QueryType.NonQuery,
                    builder
                    );
            }
        }
    }
}