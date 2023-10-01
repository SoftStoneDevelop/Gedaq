using Gedaq.Base;
using Gedaq.DbConnection.Model;
using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.SqlClient.GeneratorsQuery;
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

        public void Generate(SqlClientQuery source)
        {
            Reset();
            Start(source);

            if (source.QueryType.HasFlag(QueryType.Read))
            {
                _queryReadGenerator.Generate(source, _methodCode);
            }

            if (source.QueryType.HasFlag(QueryType.Scalar))
            {
                _queryScalarAndNonQuery.ScalarGenerate(source, _methodCode);
            }

            if (source.QueryType.HasFlag(QueryType.NonQuery))
            {
                _queryScalarAndNonQuery.NonQueryGenerate(source, _methodCode);
            }

            _commandGenerator.Generate(source, _methodCode);
            End();
        }

        private void Start(
            SqlClientQuery source
            )
        {
            _methodCode.Append($@"
using System;
using System.Data;
using System.Data.Common;
using Microsoft.Data.SqlClient;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace {source.ContainTypeName.ContainingNamespace}
{{
    {GeneratedClassDeclarationHelper.GCDeclarationName(source.ContainTypeName, source.MethodInfo, "SqlClient")}
    {{
");
        }
    }
}