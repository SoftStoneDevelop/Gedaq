﻿using Gedaq.Base;
using Gedaq.Base.Model;
using Gedaq.Base.Query;
using Gedaq.Enums;
using Gedaq.MySqlConnector.Enums;
using Gedaq.MySqlConnector.Helpers;
using Gedaq.MySqlConnector.Model;
using System.Text;

namespace Gedaq.MySqlConnector.GeneratorsQuery
{
    internal class MySqlConnectorQueryRead : QueryReadBase
    {
        private readonly MySqlConnectorProviderInfo _providerInfo = new MySqlConnectorProviderInfo();
        protected override ProviderInfo ProviderInfo => _providerInfo;

        protected override void ReadMethod(QueryBaseCommand source, StringBuilder builder)
        {
            MySqlConnectorQuery query = (MySqlConnectorQuery)source;
            if (query.SourceType.HasFlag(MySqlConnectorSourceType.MySqlConnection))
            {
                StartReadMethod(source, MethodType.Sync, builder);
                QueryMethodParametrs(
                    source,
                    builder,
                    MySqlConnectorSourceType.MySqlConnection.ToTypeName(),
                    MySqlConnectorSourceType.MySqlConnection.ToParametrName()
                    );
                EndMethodParametrs(builder, MethodType.Sync);
                ReadMethodBody(source, true, MySqlConnectorSourceType.MySqlConnection.ToParametrName(), MethodType.Sync, builder);
                EndMethod(builder);
            }

            if (query.SourceType.HasFlag(MySqlConnectorSourceType.MySqlDataSource))
            {
                StartReadMethod(source, MethodType.Sync, builder);
                QueryMethodParametrs(
                    source,
                    builder,
                    MySqlConnectorSourceType.MySqlDataSource.ToTypeName(),
                    MySqlConnectorSourceType.MySqlDataSource.ToParametrName()
                    );
                EndMethodParametrs(builder, MethodType.Sync);
                ReadMethodBody(source, false, MySqlConnectorSourceType.MySqlDataSource.ToParametrName(), MethodType.Sync, builder);
                EndMethod(builder);
            }
        }

        protected override void ReadAsyncMethod(QueryBaseCommand source, StringBuilder builder)
        {
            MySqlConnectorQuery query = (MySqlConnectorQuery)source;
            if (query.SourceType.HasFlag(MySqlConnectorSourceType.MySqlConnection))
            {
                StartReadMethod(source, MethodType.Async, builder);
                QueryMethodParametrs(
                    source,
                    builder,
                    MySqlConnectorSourceType.MySqlConnection.ToTypeName(),
                    MySqlConnectorSourceType.MySqlConnection.ToParametrName()
                    );
                EndMethodParametrs(builder, MethodType.Async);
                ReadMethodBody(source, true, MySqlConnectorSourceType.MySqlConnection.ToParametrName(), MethodType.Async, builder);
                EndMethod(builder);
            }

            if (query.SourceType.HasFlag(MySqlConnectorSourceType.MySqlDataSource))
            {
                StartReadMethod(source, MethodType.Async, builder);
                QueryMethodParametrs(
                    source,
                    builder,
                    MySqlConnectorSourceType.MySqlDataSource.ToTypeName(),
                    MySqlConnectorSourceType.MySqlDataSource.ToParametrName()
                    );
                EndMethodParametrs(builder, MethodType.Async);
                ReadMethodBody(source, false, MySqlConnectorSourceType.MySqlDataSource.ToParametrName(), MethodType.Async, builder);
                EndMethod(builder);
            }
        }
    }
}