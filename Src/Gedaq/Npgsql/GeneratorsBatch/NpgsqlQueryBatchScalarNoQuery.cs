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
        private readonly NpgsqlBatchCommon _batchCommon = new NpgsqlBatchCommon();
        protected override BatchCommonGenerator BatchCommon => _batchCommon;

        protected override void ScalarMethod(QueryBatch source, StringBuilder builder)
        {
            var npgsqlBatch = (QueryBatchNpgsql)source;
            if (npgsqlBatch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                StartScalarMethod(source, MethodType.Sync, builder);
                StartMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(), Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(), builder);
                EndMethodParametrs(builder);
                ScalarMethodBody(source, true, Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(), MethodType.Sync, QueryType.Scalar, builder);
                EndMethod(builder);
            }

            if (npgsqlBatch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                StartScalarMethod(source, MethodType.Sync, builder);
                StartMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(), Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(), builder);
                EndMethodParametrs(builder);
                ScalarMethodBody(source, false, Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(), MethodType.Sync, QueryType.Scalar, builder);
                EndMethod(builder);
            }
        }

        protected override void ScalarMethodAsync(QueryBatch source, StringBuilder builder)
        {
            var npgsqlBatch = (QueryBatchNpgsql)source;
            if (npgsqlBatch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                StartScalarMethod(source, MethodType.Async, builder);
                StartMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(), Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(), builder);
                AsyncEndMethodParametrs(builder);
                ScalarMethodBody(source, true, Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(), MethodType.Async, QueryType.Scalar, builder);
                EndMethod(builder);
            }

            if (npgsqlBatch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                StartScalarMethod(source, MethodType.Async, builder);
                StartMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(), Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(), builder);
                AsyncEndMethodParametrs(builder);
                ScalarMethodBody(source, false, Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(), MethodType.Async, QueryType.Scalar, builder);
                EndMethod(builder);
            }
        }

        protected override void NonQueryMethod(QueryBatch source, StringBuilder builder)
        {
            var npgsqlBatch = (QueryBatchNpgsql)source;
            if (npgsqlBatch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                StartNonQueryMethod(source, MethodType.Sync, builder);
                StartMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(), Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(), builder);
                EndMethodParametrs(builder);
                ScalarMethodBody(source, true, Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(), MethodType.Sync, QueryType.NonQuery, builder);
                EndMethod(builder);
            }

            if (npgsqlBatch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                StartNonQueryMethod(source, MethodType.Sync, builder);
                StartMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(), Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(), builder);
                EndMethodParametrs(builder);
                ScalarMethodBody(source, false, Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(), MethodType.Sync, QueryType.NonQuery, builder);
                EndMethod(builder);
            }
        }

        protected override void NonQueryMethodAsync(QueryBatch source, StringBuilder builder)
        {
            var npgsqlBatch = (QueryBatchNpgsql)source;
            if (npgsqlBatch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                StartNonQueryMethod(source, MethodType.Async, builder);
                StartMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(), Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(), builder);
                AsyncEndMethodParametrs(builder);
                ScalarMethodBody(source, true, Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(), MethodType.Async, QueryType.NonQuery, builder);
                EndMethod(builder);
            }

            if (npgsqlBatch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                StartNonQueryMethod(source, MethodType.Async, builder);
                StartMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(), Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(), builder);
                AsyncEndMethodParametrs(builder);
                ScalarMethodBody(source, false, Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(), MethodType.Async, QueryType.NonQuery, builder);
                EndMethod(builder);
            }
        }
    }
}