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
        NpgsqlBatchCommon _batchCommon = new NpgsqlBatchCommon();
        protected override BatchCommonGenerator BatchCommon => _batchCommon;

        protected override void ReadMethod(QueryBatch source, StringBuilder builder)
        {
            var batch = (NpgsqlQueryBatch)source;
            if (batch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                StartReadMethod(source, MethodType.Sync, builder);
                StartMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(), Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(), builder);
                EndMethodParametrs(builder);
                ReadMethodBody(source, true, Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(), MethodType.Sync, builder);
                EndMethod(builder);
            }

            if (batch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                StartReadMethod(source, MethodType.Sync, builder);
                StartMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(), Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(), builder);
                EndMethodParametrs(builder);
                ReadMethodBody(source, false, Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(), MethodType.Sync, builder);
                EndMethod(builder);
            }
        }

        protected override void ReadAsyncMethod(QueryBatch source, StringBuilder builder)
        {
            var batch = (NpgsqlQueryBatch)source;
            if (batch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                StartReadMethod(source, MethodType.Async, builder);
                StartMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(), Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(), builder);
                AsyncEndMethodParametrs(builder);
                ReadMethodBody(source, true, Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(), MethodType.Async, builder);
                EndMethod(builder);
            }

            if (batch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                StartReadMethod(source, MethodType.Async, builder);
                StartMethodParametrs(source, Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(), Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(), builder);
                AsyncEndMethodParametrs(builder);
                ReadMethodBody(source, false, Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(), MethodType.Sync, builder);
                EndMethod(builder);
            }
        }
    }
}