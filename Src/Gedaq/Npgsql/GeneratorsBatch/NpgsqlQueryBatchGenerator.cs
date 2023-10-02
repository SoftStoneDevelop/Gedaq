using Gedaq.Base;
using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.Npgsql.Model;

namespace Gedaq.Npgsql.GeneratorsBatch
{
    internal class NpgsqlQueryBatchGenerator : BaseGenerator
    {
        private readonly NpgsqlBatchCommand _batchCommand;
        private readonly NpgsqlQueryBatchRead _batchRead;
        private readonly NpgsqlQueryBatchScalarNoQuery _batchScalarNoQuery;

        public NpgsqlQueryBatchGenerator()
        {
            _batchCommand = new NpgsqlBatchCommand();
            _batchRead = new NpgsqlQueryBatchRead(_batchCommand);
            _batchScalarNoQuery = new NpgsqlQueryBatchScalarNoQuery(_batchCommand);
        }

        public void GenerateMethod(NpgsqlQueryBatch source, InterfaceGenerator interfaceGenerator)
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
            NpgsqlQueryBatch source
            )
        {
            _methodCode.Append($@"
using Npgsql;
using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace {source.ContainTypeName.ContainingNamespace.GetFullNamespace()}
{{
    {GeneratedClassDeclarationHelper.GCDeclarationName(source.ContainTypeName, source.MethodInfo, "Npgsql")}
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