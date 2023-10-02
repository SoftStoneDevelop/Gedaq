using Gedaq.Base;
using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.SqlClient.Model;

namespace Gedaq.SqlClient.GeneratorsQuery
{
    internal class SqlClientQueryGenerator : BaseGenerator
    {
        private readonly SqlClientCommandGenerator _commandGenerator;
        private readonly SqlClientQueryRead _queryReadGenerator;
        private readonly SqlClientQueryScalarAndNonQuery _queryScalarAndNonQuery;

        public SqlClientQueryGenerator()
        {
            _commandGenerator = new SqlClientCommandGenerator();
            _queryReadGenerator = new SqlClientQueryRead(_commandGenerator);
            _queryScalarAndNonQuery = new SqlClientQueryScalarAndNonQuery(_commandGenerator);
        }

        public void Generate(SqlClientQuery source, InterfaceGenerator interfaceGenerator)
        {
            Reset();
            Start(source);

            if (source.QueryType.HasFlag(QueryType.Read))
            {
                _queryReadGenerator.Generate(source, _methodCode, interfaceGenerator);
            }

            if (source.QueryType.HasFlag(QueryType.Scalar))
            {
                _queryScalarAndNonQuery.ScalarGenerate(source, _methodCode, interfaceGenerator);
            }

            if (source.QueryType.HasFlag(QueryType.NonQuery))
            {
                _queryScalarAndNonQuery.NonQueryGenerate(source, _methodCode, interfaceGenerator);
            }

            _commandGenerator.Generate(source, _methodCode, interfaceGenerator);

            EndClass();
            EndNameSpace();
        }

        public string Usings()
        {
            return @"using System;
using System.Data;
using System.Data.Common;
using Microsoft.Data.SqlClient;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;";
        }

        private void Start(
            SqlClientQuery source
            )
        {
            _methodCode.Append($@"
{Usings()}

namespace {source.ContainTypeName.ContainingNamespace.GetFullNamespace()}
{{
    {GeneratedClassDeclarationHelper.GCDeclarationName(source.ContainTypeName, source.MethodInfo, "SqlClient")}
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