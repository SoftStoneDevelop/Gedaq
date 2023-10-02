using Gedaq.Base;
using Gedaq.Base.Batch;
using Gedaq.Base.Model;
using Gedaq.Enums;
using Gedaq.Npgsql.Helpers;
using Gedaq.Npgsql.Model;
using System.Text;

namespace Gedaq.Npgsql.GeneratorsBatch
{
    internal class NpgsqlQueryBatchScalarNoQuery : QueryBatchScalarNoQueryBase
    {
        NpgsqlProviderInfo _providerInfo = new NpgsqlProviderInfo();

        public NpgsqlQueryBatchScalarNoQuery(NpgsqlBatchCommand commandGenerator) : base(commandGenerator)
        {

        }

        protected override ProviderInfo ProviderInfo => _providerInfo;

        protected override void ScalarMethod(
            QueryBatchCommand source, 
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator
            )
        {
            var batch = (NpgsqlQueryBatch)source;
            if (batch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                ScalarMethodInner(
                    source,
                    MethodType.Sync,
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(), 
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(),
                    builder,
                    needCheckOpen: true,
                    interfaceGenerator
                    );
            }

            if (batch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                ScalarMethodInner(
                    source,
                    MethodType.Sync,
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(),
                    builder,
                    needCheckOpen: false,
                    interfaceGenerator
                    );
            }
        }

        protected override void ScalarMethodAsync(
            QueryBatchCommand source, 
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator
            )
        {
            var batch = (NpgsqlQueryBatch)source;
            if (batch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                ScalarMethodInner(
                    source,
                    MethodType.Async,
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(),
                    builder,
                    needCheckOpen: true,
                    interfaceGenerator
                    );
            }

            if (batch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                ScalarMethodInner(
                    source,
                    MethodType.Async,
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(),
                    builder,
                    needCheckOpen: false,
                    interfaceGenerator
                    );
            }
        }

        protected override void NonQueryMethod(
            QueryBatchCommand source, 
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator
            )
        {
            var batch = (NpgsqlQueryBatch)source;
            if (batch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                NonQueryMethodInner(
                    source,
                    MethodType.Sync,
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(), 
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(),
                    builder,
                    needCheckOpen: true,
                    interfaceGenerator
                    );
            }

            if (batch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                NonQueryMethodInner(
                    source,
                    MethodType.Sync,
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(),
                    builder,
                    needCheckOpen: false,
                    interfaceGenerator
                    );
            }
        }

        protected override void NonQueryMethodAsync(
            QueryBatchCommand source, 
            StringBuilder builder,
            InterfaceGenerator interfaceGenerator
            )
        {
            var batch = (NpgsqlQueryBatch)source;
            if (batch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlConnection))
            {
                NonQueryMethodInner(
                    source,
                    MethodType.Async,
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlConnection.ToParametrName(),
                    builder,
                    needCheckOpen: true,
                    interfaceGenerator
                    );
            }

            if (batch.SourceType.HasFlag(Enums.NpgsqlSourceType.NpgsqlDataSource))
            {
                NonQueryMethodInner(
                    source,
                    MethodType.Async,
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToTypeName(),
                    Enums.NpgsqlSourceType.NpgsqlDataSource.ToParametrName(),
                    builder,
                    needCheckOpen: false,
                    interfaceGenerator
                    );
            }
        }
    }
}