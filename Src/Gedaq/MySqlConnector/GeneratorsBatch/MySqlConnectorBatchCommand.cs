﻿using Gedaq.Base.Batch;
using Gedaq.Base.Model;
using Gedaq.Enums;
using Gedaq.MySqlConnector.Enums;
using Gedaq.MySqlConnector.Helpers;
using Gedaq.MySqlConnector.Model;
using System.Text;

namespace Gedaq.MySqlConnector.GeneratorsBatch
{
    internal class MySqlConnectorBatchCommand : BatchCommandBase
    {
        private readonly MySqlConnectorBatchCommon _batchCommon = new MySqlConnectorBatchCommon();
        protected override BatchCommonGenerator BatchCommon => _batchCommon;

        protected override void CreateBatchMethods(QueryBatch source, StringBuilder builder)
        {
            var npgsqlBatch = (MySqlConnectorQueryBatch)source;
            if (source.MethodType.HasFlag(MethodType.Sync))
            {
                if (npgsqlBatch.SourceType.HasFlag(MySqlConnectorSourceType.MySqlConnection))
                {
                    CreateBatchMethod(source, MySqlConnectorSourceType.MySqlConnection.ToTypeName(), MySqlConnectorSourceType.MySqlConnection.ToParametrName(), MethodType.Sync, builder);
                }

                if (npgsqlBatch.SourceType.HasFlag(MySqlConnectorSourceType.MySqlDataSource))
                {
                    CreateBatchMethod(source, MySqlConnectorSourceType.MySqlDataSource.ToTypeName(), MySqlConnectorSourceType.MySqlDataSource.ToParametrName(), MethodType.Sync, builder);
                }
            }

            if (source.MethodType.HasFlag(MethodType.Async))
            {
                if (npgsqlBatch.SourceType.HasFlag(MySqlConnectorSourceType.MySqlConnection))
                {
                    CreateBatchMethod(source, MySqlConnectorSourceType.MySqlConnection.ToTypeName(), MySqlConnectorSourceType.MySqlConnection.ToParametrName(), MethodType.Async, builder);
                }

                if (npgsqlBatch.SourceType.HasFlag(MySqlConnectorSourceType.MySqlDataSource))
                {
                    CreateBatchMethod(source, MySqlConnectorSourceType.MySqlDataSource.ToTypeName(), MySqlConnectorSourceType.MySqlDataSource.ToParametrName(), MethodType.Async, builder);
                }
            }

            SetParametrsMethod(source, builder);
        }

        protected override void CreateParametr(BaseParametr baseParametr, int index, StringBuilder builder)
        {
            MySqlConnectorGeneratorHelper.CreateParametr(baseParametr, index, builder);
        }
    }
}