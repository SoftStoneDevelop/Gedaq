using Gedaq.Base;
using Gedaq.Base.Model;
using Gedaq.Base.Query;
using Gedaq.Enums;
using Gedaq.Npgsql.Helpers;
using Gedaq.Npgsql.Model;
using System.Text;

namespace Gedaq.Npgsql.GeneratorsQuery
{
    internal class NpgsqlQueryScalarAndNonQuery : QueryScalarNonQueryBase
    {
        private readonly NpgsqlProviderInfo _providerInfo = new NpgsqlProviderInfo();

        public NpgsqlQueryScalarAndNonQuery(NpgsqlCommand commandGenerator) : base(commandGenerator)
        {

        }

        protected override ProviderInfo ProviderInfo => _providerInfo;

        protected override void NonQueryMethod(QueryBaseCommand source, StringBuilder builder)
        {
            var query = (NpgsqlQuery)source;
            if (query.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                NonQueryMethodDefinition(
                    source,
                    MethodType.Sync,
                    builder,
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(),
                    useInAndOut: true
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

            if (query.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                NonQueryMethodDefinition(
                    source,
                    MethodType.Sync,
                    builder,
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(),
                    useInAndOut: true
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

        protected override void NonQueryMethodAsync(QueryBaseCommand source, StringBuilder builder)
        {
            var query = (NpgsqlQuery)source;
            if (query.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                NonQueryMethodDefinition(
                    source,
                    MethodType.Async,
                    builder,
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(),
                    useInAndOut: false
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

            if (query.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                NonQueryMethodDefinition(
                    source,
                    MethodType.Async,
                    builder,
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(),
                    useInAndOut: false
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

        protected override void ScalarMethod(QueryBaseCommand source, StringBuilder builder)
        {
            var query = (NpgsqlQuery)source;
            if (query.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                ScalarMethodDefinition(
                    source,
                    MethodType.Sync,
                    builder,
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(),
                    useInAndOut: true
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

            if (query.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                ScalarMethodDefinition(
                    source,
                    MethodType.Sync,
                    builder,
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(),
                    useInAndOut: true
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

        protected override void ScalarMethodAsync(QueryBaseCommand source, StringBuilder builder)
        {
            var query = (NpgsqlQuery)source;
            if (query.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                ScalarMethodDefinition(
                    source,
                    MethodType.Async,
                    builder,
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(),
                    useInAndOut: false
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

            if (query.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                ScalarMethodDefinition(
                    source,
                    MethodType.Async,
                    builder,
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(),
                    useInAndOut: false
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
    }
}