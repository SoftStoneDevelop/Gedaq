using Gedaq.Base;
using Gedaq.Enums;
using Gedaq.MySqlConnector.Model;

namespace Gedaq.MySqlConnector.GeneratorsBatch
{
    internal class MySqlConnectorQueryBatchGenerator : BaseGenerator
    {
        MySqlConnectorQueryBatchRead _batchRead = new MySqlConnectorQueryBatchRead();
        MySqlConnectorQueryBatchScalarNoQuery _batchScalarNoQuery = new MySqlConnectorQueryBatchScalarNoQuery();
        MySqlConnectorBatchCommand _batchCommand = new MySqlConnectorBatchCommand();

        public void GenerateMethod(MySqlConnectorQueryBatch source)
        {
            Reset();
            Start(source);

            if (source.QueryType.HasFlag(QueryType.Read))
            {
                _batchRead.Generate(source, _methodCode);
            }

            if (source.QueryType.HasFlag(QueryType.Scalar))
            {
                _batchScalarNoQuery.GenerateScalar(source, _methodCode);
            }

            if (source.QueryType.HasFlag(QueryType.NonQuery))
            {
                _batchScalarNoQuery.GenerateNonQuery(source, _methodCode);
            }

            _batchCommand.Generate(source, _methodCode);

            End();
        }

        private void Start(
            MySqlConnectorQueryBatch source
            )
        {
            _methodCode.Append($@"
using MySqlConnector;
using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace {source.ContainTypeName.ContainingNamespace}
{{
    public static class {source.MethodName}MySqlConnectorExtension
    {{
");
        }
    }
}