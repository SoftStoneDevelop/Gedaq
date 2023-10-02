using Gedaq.Base;
using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.MySqlConnector.Model;

namespace Gedaq.MySqlConnector.GeneratorsBatch
{
    internal class MySqlConnectorQueryBatchGenerator : BaseGenerator
    {
        private readonly MySqlConnectorBatchCommand _batchCommand;
        private readonly MySqlConnectorQueryBatchRead _batchRead;
        private readonly MySqlConnectorQueryBatchScalarNoQuery _batchScalarNoQuery;

        public MySqlConnectorQueryBatchGenerator()
        {
            _batchCommand = new MySqlConnectorBatchCommand();
            _batchRead = new MySqlConnectorQueryBatchRead(_batchCommand);
            _batchScalarNoQuery = new MySqlConnectorQueryBatchScalarNoQuery(_batchCommand);
        }


        public void GenerateMethod(MySqlConnectorQueryBatch source, InterfaceGenerator interfaceGenerator)
        {
            Reset();
            Start(source);

            if (source.QueryType.HasFlag(QueryType.Read))
            {
                _batchRead.Generate(source, _methodCode, interfaceGenerator);
            }

            if (source.QueryType.HasFlag(QueryType.Scalar))
            {
                _batchScalarNoQuery.GenerateScalar(source, _methodCode, interfaceGenerator);
            }

            if (source.QueryType.HasFlag(QueryType.NonQuery))
            {
                _batchScalarNoQuery.GenerateNonQuery(source, _methodCode, interfaceGenerator);
            }

            _batchCommand.Generate(source, _methodCode, interfaceGenerator);

            EndClass();
            EndNameSpace();
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

namespace {source.ContainTypeName.ContainingNamespace.GetFullNamespace()}
{{
    {GeneratedClassDeclarationHelper.GCDeclarationName(source.ContainTypeName, source.MethodInfo, "MySqlConnector")}
    {{
");
        }

        private void EndClass()
        {
            _methodCode.Append($@"
    }}");
        }

        private void EndNameSpace()
        {
            _methodCode.Append($@"
}}");
        }
    }
}