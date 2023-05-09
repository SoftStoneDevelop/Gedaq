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
        protected override ProviderInfo ProviderInfo => _providerInfo;

        protected override void ScalarMethod(QueryBatchCommand source, StringBuilder builder)
        {
            var batch = (NpgsqlQueryBatch)source;
            if (batch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                StartScalarMethod(source, MethodType.Sync, builder);
                StartMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(), Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(), builder);
                EndMethodParametrs(builder, MethodType.Sync);
                ScalarMethodBody(source, true, Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(), MethodType.Sync, QueryType.Scalar, builder);
                EndMethod(builder);
            }

            if (batch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                StartScalarMethod(source, MethodType.Sync, builder);
                StartMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(), Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(), builder);
                EndMethodParametrs(builder, MethodType.Sync);
                ScalarMethodBody(source, false, Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(), MethodType.Sync, QueryType.Scalar, builder);
                EndMethod(builder);
            }
        }

        protected override void ScalarMethodAsync(QueryBatchCommand source, StringBuilder builder)
        {
            var batch = (NpgsqlQueryBatch)source;
            if (batch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                StartScalarMethod(source, MethodType.Async, builder);
                StartMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(), Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(), builder);
                EndMethodParametrs(builder, MethodType.Async);
                ScalarMethodBody(source, true, Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(), MethodType.Async, QueryType.Scalar, builder);
                EndMethod(builder);
            }

            if (batch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                StartScalarMethod(source, MethodType.Async, builder);
                StartMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(), Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(), builder);
                EndMethodParametrs(builder, MethodType.Async);
                ScalarMethodBody(source, false, Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(), MethodType.Async, QueryType.Scalar, builder);
                EndMethod(builder);
            }
        }

        protected override void NonQueryMethod(QueryBatchCommand source, StringBuilder builder)
        {
            var batch = (NpgsqlQueryBatch)source;
            if (batch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                StartNonQueryMethod(source, MethodType.Sync, builder);
                StartMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(), Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(), builder);
                EndMethodParametrs(builder, MethodType.Sync);
                ScalarMethodBody(source, true, Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(), MethodType.Sync, QueryType.NonQuery, builder);
                EndMethod(builder);
            }

            if (batch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                StartNonQueryMethod(source, MethodType.Sync, builder);
                StartMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(), Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(), builder);
                EndMethodParametrs(builder, MethodType.Sync);
                ScalarMethodBody(source, false, Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(), MethodType.Sync, QueryType.NonQuery, builder);
                EndMethod(builder);
            }
        }

        protected override void NonQueryMethodAsync(QueryBatchCommand source, StringBuilder builder)
        {
            var batch = (NpgsqlQueryBatch)source;
            if (batch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                StartNonQueryMethod(source, MethodType.Async, builder);
                StartMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(), Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(), builder);
                EndMethodParametrs(builder, MethodType.Async);
                ScalarMethodBody(source, true, Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(), MethodType.Async, QueryType.NonQuery, builder);
                EndMethod(builder);
            }

            if (batch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                StartNonQueryMethod(source, MethodType.Async, builder);
                StartMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(), Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(), builder);
                EndMethodParametrs(builder, MethodType.Async);
                ScalarMethodBody(source, false, Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(), MethodType.Async, QueryType.NonQuery, builder);
                EndMethod(builder);
            }
        }
    }
}