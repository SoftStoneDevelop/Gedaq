using Gedaq.Base;
using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.Npgsql.Model;

namespace Gedaq.Npgsql.GeneratorsBatch
{
    internal class NpgsqlQueryBatchGenerator : QueryBaseGenerator
    {
        NpgsqlQueryBatchRead _batchRead = new NpgsqlQueryBatchRead();
        NpgsqlQueryBatchScalarNoQuery _batchScalarNoQuery = new NpgsqlQueryBatchScalarNoQuery();
        NpgsqlBatchCommand _batchCommand = new NpgsqlBatchCommand();

        public void GenerateMethod(QueryBatchNpgsql source)
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
            QueryBatchNpgsql source
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

namespace {source.ContainTypeName.ContainingNamespace}
{{
    public static class {source.MethodName}NpgsqlExtension
    {{
");
        }
    }
}