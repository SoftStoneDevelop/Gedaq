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

        public NpgsqlQueryRead(NpgsqlCommand commandGenerator) : base(commandGenerator)
        {

        }

        protected override ProviderInfo ProviderInfo => _providerInfo;

        protected override void ReadMethod(
            QueryBaseCommand source, 
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator
            )
        {
            NpgsqlQuery query = (NpgsqlQuery)source;
            if (query.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                ReadMethodInner(
                    source,
                    MethodType.Sync,
                    builder,
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(),
                    needCheckOpen: true,
                    interfaceGenerator
                    );
            }

            if (query.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                ReadMethodInner(
                    source,
                    MethodType.Sync,
                    builder,
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(),
                    needCheckOpen: false,
                    interfaceGenerator
                    );
            }
        }

        protected override void ReadAsyncMethod(
            QueryBaseCommand source, 
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator
            )
        {
            NpgsqlQuery query = (NpgsqlQuery)source;
            if (query.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                ReadMethodInner(
                    source,
                    MethodType.Async,
                    builder,
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(),
                    needCheckOpen: true,
                    interfaceGenerator
                    );
            }

            if (query.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                ReadMethodInner(
                    source,
                    MethodType.Async,
                    builder,
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(),
                    needCheckOpen: false,
                    interfaceGenerator
                    );
            }
        }
    }
}