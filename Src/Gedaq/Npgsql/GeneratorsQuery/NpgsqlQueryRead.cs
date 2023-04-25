using Gedaq.Base;
using Gedaq.Base.Model;
using Gedaq.Base.Query;
using Gedaq.Enums;
using Gedaq.Npgsql.Helpers;
using Gedaq.Npgsql.Model;
using System.Text;

namespace Gedaq.Npgsql.GeneratorsQuery
{
    internal class NpgsqlQueryRead : QueryReadBase
    {
        private readonly NpgsqlProviderInfo _providerInfo = new NpgsqlProviderInfo();
        protected override ProviderInfo ProviderInfo => _providerInfo;

        protected override void ReadMethod(QueryBase source, StringBuilder builder)
        {
            NpgsqlQuery query = (NpgsqlQuery)source;
            if (query.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                StartReadMethod(source, MethodType.Sync, builder);
                QueryMethodParametrs(
                    source,
                    builder,
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName()
                    );
                EndMethodParametrs(builder, MethodType.Sync);
                ReadMethodBody(source, true, Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(), MethodType.Sync, builder);
                EndMethod(builder);
            }

            if (query.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                StartReadMethod(source, MethodType.Sync, builder);
                QueryMethodParametrs(
                    source,
                    builder,
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName()
                    );
                EndMethodParametrs(builder, MethodType.Sync);
                ReadMethodBody(source, false, Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(), MethodType.Sync, builder);
                EndMethod(builder);
            }
        }

        protected override void ReadAsyncMethod(QueryBase source, StringBuilder builder)
        {
            NpgsqlQuery query = (NpgsqlQuery)source;
            if (query.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                StartReadMethod(source, MethodType.Async, builder);
                QueryMethodParametrs(
                    source,
                    builder,
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName()
                    );
                EndMethodParametrs(builder, MethodType.Async);
                ReadMethodBody(source, true, Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(), MethodType.Async, builder);
                EndMethod(builder);
            }

            if (query.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                StartReadMethod(source, MethodType.Async, builder);
                QueryMethodParametrs(
                    source,
                    builder,
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName()
                    );
                EndMethodParametrs(builder, MethodType.Async);
                ReadMethodBody(source, false, Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(), MethodType.Async, builder);
                EndMethod(builder);
            }
        }
    }
}