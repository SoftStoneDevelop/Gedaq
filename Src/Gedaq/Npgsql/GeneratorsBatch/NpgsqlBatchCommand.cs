using Gedaq.Base.Batch;
using Gedaq.Base.Model;
using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.Npgsql.Helpers;
using Gedaq.Npgsql.Model;
using System.Text;

namespace Gedaq.Npgsql.GeneratorsBatch
{
    internal class NpgsqlBatchCommand : BatchCommandBase
    {
        private readonly NpgsqlBatchCommon _batchCommon = new NpgsqlBatchCommon();
        protected override BatchCommonGenerator BatchCommon => _batchCommon;

        protected override void CreateBatchMethods(QueryBatch source, StringBuilder builder)
        {
            var npgsqlBatch = (NpgsqlQueryBatch)source;
            if (source.MethodType.HasFlag(MethodType.Sync))
            {
                if (npgsqlBatch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
                {
                    CreateBatchMethod(source, Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(), Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(), MethodType.Sync, builder);
                }

                if (npgsqlBatch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
                {
                    CreateBatchMethod(source, Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(), Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(), MethodType.Sync, builder);
                }
            }

            if (source.MethodType.HasFlag(MethodType.Async))
            {
                if (npgsqlBatch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
                {
                    CreateBatchMethod(source, Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(), Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(), MethodType.Async, builder);
                }

                if (npgsqlBatch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
                {
                    CreateBatchMethod(source, Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(), Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(), MethodType.Async, builder);
                }
            }

            SetParametrsMethod(source, builder);
        }

        protected override void CreateParametr(BaseParametr baseParametr, int index, StringBuilder builder)
        {
            NpgsqlGeneratorHelper.CreateParametr(baseParametr, index, builder);
        }
    }
}