using Gedaq.Base.Model;
using Gedaq.Base.Query;
using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.Npgsql.Helpers;
using Gedaq.Npgsql.Model;
using System.Text;

namespace Gedaq.Npgsql.GeneratorsQuery
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
            NpgsqlGeneratorHelper.CreateParametr(baseParametr, index, builder);
        }
    }
}