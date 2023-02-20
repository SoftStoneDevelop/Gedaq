﻿using Gedaq.Base;
using Gedaq.DbConnection.Model;
using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.Npgsql.Generators;
using Microsoft.CodeAnalysis;
using System;

namespace Gedaq.DbConnection.Generators
{
    internal class DbQueryBatchGenerator : QueryBaseGenerator
    {
        DbQueryBatchRead _batchRead = new DbQueryBatchRead();
        DbQueryBatchScalarNoQuery _batchScalarNoQuery = new DbQueryBatchScalarNoQuery();
        DbBatchCommand _batchCommand = new DbBatchCommand();

        public void Generate(DbQueryBatch source)
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

namespace {source.ContainTypeName.ContainingNamespace}
{{
    public static class {source.MethodName}DbConnectionExtension
    {{
");
        }
    }
}