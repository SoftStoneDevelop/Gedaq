using Gedaq.Base;
using Gedaq.Base.Model;
using Gedaq.Base.Query;
using Gedaq.Enums;
using Gedaq.MySqlConnector.GeneratorsQuery;
using Gedaq.Npgsql.Helpers;
using Gedaq.Npgsql.Model;
using System.Text;

namespace Gedaq.Npgsql.GeneratorsQuery
{
    internal class NpgsqlQueryRead : QueryReadBase
    {
        private readonly NpgsqlProviderInfo _providerInfo = new NpgsqlProviderInfo();

        public NpgsqlQueryRead(NpgsqlCommand commandGenerator) : base(commandGenerator)
        {

        }

        protected override ProviderInfo ProviderInfo => _providerInfo;

        protected override void ReadMethod(QueryBaseCommand source, StringBuilder builder)
        {
            NpgsqlQuery query = (NpgsqlQuery)source;
            if (query.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
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

            if (query.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
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

        protected override void ReadAsyncMethod(QueryBaseCommand source, StringBuilder builder)
        {
            NpgsqlQuery query = (NpgsqlQuery)source;
            if (query.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
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

            if (query.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
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