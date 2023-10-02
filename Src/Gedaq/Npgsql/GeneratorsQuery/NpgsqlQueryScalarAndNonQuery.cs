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

        protected override void NonQueryMethod(
            QueryBaseCommand source, 
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator
            )
        {
            var query = (NpgsqlQuery)source;
            if (query.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                NonQueryMethodInner(
                    source,
                    MethodType.Sync,
                    builder,
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(),
                    useInAndOut: true,
                    needCheckOpen: true,
                    interfaceGenerator
                    );
            }

            if (query.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                NonQueryMethodInner(
                    source,
                    MethodType.Sync,
                    builder,
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(),
                    useInAndOut: true,
                    needCheckOpen: false,
                    interfaceGenerator
                    );
            }
        }

        protected override void NonQueryMethodAsync(
            QueryBaseCommand source, 
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator
            )
        {
            var query = (NpgsqlQuery)source;
            if (query.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                NonQueryMethodInner(
                    source,
                    MethodType.Async,
                    builder,
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(),
                    useInAndOut: false,
                    needCheckOpen: true,
                    interfaceGenerator
                    );
            }

            if (query.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                NonQueryMethodInner(
                    source,
                    MethodType.Async,
                    builder,
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(),
                    useInAndOut: false,
                    needCheckOpen: false,
                    interfaceGenerator
                    );
            }
        }

        protected override void ScalarMethod(
            QueryBaseCommand source, 
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator
            )
        {
            var query = (NpgsqlQuery)source;
            if (query.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                ScalarMethodInner(
                    source,
                    MethodType.Sync,
                    builder,
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(),
                    useInAndOut: true,
                    needCheckOpen: true,
                    interfaceGenerator
                    );
            }

            if (query.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                ScalarMethodInner(
                    source,
                    MethodType.Sync,
                    builder,
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(),
                    useInAndOut: true,
                    needCheckOpen: false,
                    interfaceGenerator
                    );
            }
        }

        protected override void ScalarMethodAsync(
            QueryBaseCommand source, 
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator
            )
        {
            var query = (NpgsqlQuery)source;
            if (query.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                ScalarMethodInner(
                    source,
                    MethodType.Async,
                    builder,
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(),
                    useInAndOut: false,
                    needCheckOpen: true,
                    interfaceGenerator
                    );
            }

            if (query.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                ScalarMethodInner(
                    source,
                    MethodType.Async,
                    builder,
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(),
                    useInAndOut: false,
                    needCheckOpen: false,
                    interfaceGenerator
                    );
            }
        }
    }
}