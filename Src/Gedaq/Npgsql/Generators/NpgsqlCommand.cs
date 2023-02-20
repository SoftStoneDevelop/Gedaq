using Gedaq.Base;
using Gedaq.DbConnection.Model;
using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.Npgsql.Helpers;
using Gedaq.Npgsql.Model;
using System.Text;

namespace Gedaq.Npgsql.Generators
{
    internal class NpgsqlCommand : CommandGeneratorBase
    {
        private readonly NpgsqlQueryCommon _queryCommon = new NpgsqlQueryCommon();
        protected override QueryCommonBase QueryCommon => _queryCommon;

        protected override void GenrateCommand(QueryBase baseSource, StringBuilder builder)
        {
            QueryReadNpgsql source = (QueryReadNpgsql)baseSource;
            if (baseSource.MethodType.HasFlag(MethodType.Sync))
            {
                if (source.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
                {
                    CreateCommandMethod(
                        baseSource,
                        Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(),
                        Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(),
                        MethodType.Sync, builder
                        );
                }

                if (source.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
                {
                    CreateCommandMethod(
                        baseSource,
                        Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(),
                        Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(),
                        MethodType.Sync, builder
                        );
                }
            }

            if (baseSource.MethodType.HasFlag(MethodType.Async))
            {
                if (source.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
                {
                    CreateCommandMethod(
                        baseSource,
                        Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(),
                        Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(),
                        MethodType.Async, builder
                        );
                }

                if (source.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
                {
                    CreateCommandMethod(
                        baseSource,
                        Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(),
                        Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(),
                        MethodType.Async, builder
                        );
                }
            }
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