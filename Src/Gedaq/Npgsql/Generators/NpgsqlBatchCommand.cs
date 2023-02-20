using Gedaq.Base;
using Gedaq.DbConnection.Model;
using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.Npgsql.Helpers;
using Gedaq.Npgsql.Model;
using System.Text;

namespace Gedaq.Npgsql.Generators
{
    internal class NpgsqlBatchCommand : BatchCommandBase
    {
        private readonly NpgsqlBatchCommon _batchCommon = new NpgsqlBatchCommon();
        protected override BatchCommonGenerator BatchCommon => _batchCommon;

        protected override void CreateBatchMethods(QueryBatch source, StringBuilder builder)
        {
            var npgsqlBatch = (QueryBatchNpgsql)source;
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
            var parametr = (NpgsqlParametr)baseParametr;
            if (parametr.Type.IsNullableType())
            {
                builder.Append($@"
                var parametr{parametr.Position} = new NpgsqlParameter();
");
            }
            else
            {
                builder.Append($@"
                var parametr{parametr.Position} = new NpgsqlParameter<{parametr.Type.GetFullTypeName()}>();
");
            }

            if (parametr.HaveNpgSqlDbType)
            {
                builder.Append($@"
                parametr{parametr.Position}.NpgsqlDbType = ({NpgsqlMapTypeHelper.NpgsqlDbTypeName}){parametr.NpgSqlDbType};
");
            }

            if (parametr.HaveName)
            {
                builder.Append($@"
                parametr{parametr.Position}.ParameterName = ""{parametr.Name}"";
");
            }

            if (parametr.HaveSize)
            {
                builder.Append($@"
                parametr{parametr.Position}.Size = {parametr.Size};
");
            }

            if (parametr.Nullable)
            {
                builder.Append($@"
                parametr{parametr.Position}.IsNullable = true;
");
            }

            if (parametr.Direction != System.Data.ParameterDirection.Input)
            {
                builder.Append($@"
                parametr{parametr.Position}.Direction = System.Data.ParameterDirection.{parametr.Direction.ToString()};
");
            }

            builder.Append($@"
                command.Parameters.Add(parametr{parametr.Position});
");
        }
    }
}