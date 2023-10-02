using Gedaq.Base;
using Gedaq.DbConnection.Model;
using Gedaq.Enums;
using Gedaq.Helpers;

namespace Gedaq.DbConnection.GeneratorsBatch
{
    internal class DbQueryBatchGenerator : BaseGenerator
    {
        private readonly DbBatchCommand _batchCommand;
        private readonly DbQueryBatchRead _batchRead;
        private readonly DbQueryBatchScalarNoQuery _batchScalarNoQuery;

        public DbQueryBatchGenerator()
        {
            _batchCommand = new DbBatchCommand();
            _batchRead = new DbQueryBatchRead(_batchCommand);
            _batchScalarNoQuery = new DbQueryBatchScalarNoQuery(_batchCommand);
        }

        public void Generate(DbQueryBatch source, InterfaceGenerator interfaceGenerator)
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
            DbQueryBatch source
            )
        {
            _methodCode.Append($@"
using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace {source.ContainTypeName.ContainingNamespace.GetFullNamespace()}
{{
    {GeneratedClassDeclarationHelper.GCDeclarationName(source.ContainTypeName, source.MethodInfo, "DbConnection")}
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