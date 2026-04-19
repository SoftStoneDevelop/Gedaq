using Gedaq.Base;
using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.Npgsql.Model;
using Microsoft.CodeAnalysis;

namespace Gedaq.Npgsql.GeneratorsBatch
{
    internal class NpgsqlQueryBatchGenerator : BaseGenerator
    {
        private readonly NpgsqlBatchCommand _batchCommand;
        private readonly NpgsqlQueryBatchRead _batchRead;
        private readonly NpgsqlQueryBatchScalarNoQuery _batchScalarNoQuery;

        public NpgsqlQueryBatchGenerator(
            SourceProductionContext context,
            NpgsqlProviderInfo providerInfo)
            : base (context)
        {
            _batchCommand = new NpgsqlBatchCommand(providerInfo);
            _batchRead = new NpgsqlQueryBatchRead(_batchCommand, providerInfo);
            _batchScalarNoQuery = new NpgsqlQueryBatchScalarNoQuery(_batchCommand, providerInfo);
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

            _batchCommand.Generate(source, _methodCode, interfaceGenerator, _context);

            EndClass();
            EndNameSpace();
        }

        private void Start(NpgsqlQueryBatch source)
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