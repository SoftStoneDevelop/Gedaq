﻿using Gedaq.Base.Batch;
using Gedaq.Base.Model;
using Gedaq.Enums;
using Gedaq.MySqlConnector.Enums;
using Gedaq.MySqlConnector.Helpers;
using Gedaq.MySqlConnector.Model;
using System.Text;

namespace Gedaq.MySqlConnector.GeneratorsBatch
{
    internal class MySqlConnectorQueryBatchScalarNoQuery : QueryBatchScalarNoQueryBase
    {
        private readonly MySqlConnectorBatchCommon _batchCommon = new MySqlConnectorBatchCommon();
        protected override BatchCommonGenerator BatchCommon => _batchCommon;

        protected override void ScalarMethod(QueryBatch source, StringBuilder builder)
        {
            var batch = (MySqlConnectorQueryBatch)source;
            if (batch.SourceType.HasFlag(MySqlConnectorSourceType.MySqlConnection))
            {
                StartScalarMethod(source, MethodType.Sync, builder);
                StartMethodParametrs(source, MySqlConnectorSourceType.MySqlConnection.ToTypeName(), MySqlConnectorSourceType.MySqlConnection.ToParametrName(), builder);
                EndMethodParametrs(builder);
                ScalarMethodBody(source, true, MySqlConnectorSourceType.MySqlConnection.ToParametrName(), MethodType.Sync, QueryType.Scalar, builder);
                EndMethod(builder);
            }

            if (batch.SourceType.HasFlag(MySqlConnectorSourceType.MySqlDataSource))
            {
                StartScalarMethod(source, MethodType.Sync, builder);
                StartMethodParametrs(source, MySqlConnectorSourceType.MySqlDataSource.ToTypeName(), MySqlConnectorSourceType.MySqlDataSource.ToParametrName(), builder);
                EndMethodParametrs(builder);
                ScalarMethodBody(source, false, MySqlConnectorSourceType.MySqlDataSource.ToParametrName(), MethodType.Sync, QueryType.Scalar, builder);
                EndMethod(builder);
            }
        }

        protected override void ScalarMethodAsync(QueryBatch source, StringBuilder builder)
        {
            var batch = (MySqlConnectorQueryBatch)source;
            if (batch.SourceType.HasFlag(MySqlConnectorSourceType.MySqlConnection))
            {
                StartScalarMethod(source, MethodType.Async, builder);
                StartMethodParametrs(source, MySqlConnectorSourceType.MySqlConnection.ToTypeName(), MySqlConnectorSourceType.MySqlConnection.ToParametrName(), builder);
                AsyncEndMethodParametrs(builder);
                ScalarMethodBody(source, true, MySqlConnectorSourceType.MySqlConnection.ToParametrName(), MethodType.Async, QueryType.Scalar, builder);
                EndMethod(builder);
            }

            if (batch.SourceType.HasFlag(MySqlConnectorSourceType.MySqlDataSource))
            {
                StartScalarMethod(source, MethodType.Async, builder);
                StartMethodParametrs(source, MySqlConnectorSourceType.MySqlDataSource.ToTypeName(), MySqlConnectorSourceType.MySqlDataSource.ToParametrName(), builder);
                AsyncEndMethodParametrs(builder);
                ScalarMethodBody(source, false, MySqlConnectorSourceType.MySqlDataSource.ToParametrName(), MethodType.Async, QueryType.Scalar, builder);
                EndMethod(builder);
            }
        }

        protected override void NonQueryMethod(QueryBatch source, StringBuilder builder)
        {
            var batch = (MySqlConnectorQueryBatch)source;
            if (batch.SourceType.HasFlag(MySqlConnectorSourceType.MySqlConnection))
            {
                StartNonQueryMethod(source, MethodType.Sync, builder);
                StartMethodParametrs(source, MySqlConnectorSourceType.MySqlConnection.ToTypeName(), MySqlConnectorSourceType.MySqlConnection.ToParametrName(), builder);
                EndMethodParametrs(builder);
                ScalarMethodBody(source, true, MySqlConnectorSourceType.MySqlConnection.ToParametrName(), MethodType.Sync, QueryType.NonQuery, builder);
                EndMethod(builder);
            }

            if (batch.SourceType.HasFlag(MySqlConnectorSourceType.MySqlDataSource))
            {
                StartNonQueryMethod(source, MethodType.Sync, builder);
                StartMethodParametrs(source, MySqlConnectorSourceType.MySqlDataSource.ToTypeName(), MySqlConnectorSourceType.MySqlDataSource.ToParametrName(), builder);
                EndMethodParametrs(builder);
                ScalarMethodBody(source, false, MySqlConnectorSourceType.MySqlDataSource.ToParametrName(), MethodType.Sync, QueryType.NonQuery, builder);
                EndMethod(builder);
            }
        }

        protected override void NonQueryMethodAsync(QueryBatch source, StringBuilder builder)
        {
            var batch = (MySqlConnectorQueryBatch)source;
            if (batch.SourceType.HasFlag(MySqlConnectorSourceType.MySqlConnection))
            {
                StartNonQueryMethod(source, MethodType.Async, builder);
                StartMethodParametrs(source, MySqlConnectorSourceType.MySqlConnection.ToTypeName(), MySqlConnectorSourceType.MySqlConnection.ToParametrName(), builder);
                AsyncEndMethodParametrs(builder);
                ScalarMethodBody(source, true, MySqlConnectorSourceType.MySqlConnection.ToParametrName(), MethodType.Async, QueryType.NonQuery, builder);
                EndMethod(builder);
            }

            if (batch.SourceType.HasFlag(MySqlConnectorSourceType.MySqlDataSource))
            {
                StartNonQueryMethod(source, MethodType.Async, builder);
                StartMethodParametrs(source, MySqlConnectorSourceType.MySqlDataSource.ToTypeName(), MySqlConnectorSourceType.MySqlDataSource.ToParametrName(), builder);
                AsyncEndMethodParametrs(builder);
                ScalarMethodBody(source, false, MySqlConnectorSourceType.MySqlDataSource.ToParametrName(), MethodType.Async, QueryType.NonQuery, builder);
                EndMethod(builder);
            }
        }
    }
}