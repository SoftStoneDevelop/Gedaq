using Gedaq.DbConnection.Model;
using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.Npgsql.Generators;
using Gedaq.Npgsql.Model;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Gedaq.DbConnection.Generators
{
    internal class QueryGenerator : QueryBaseGenerator
    {
        DbQueryRead _queryReadGenerator = new DbQueryRead();
        DbQueryScalarAndNonQuery _queryScalarAndNonQuery = new DbQueryScalarAndNonQuery();
        DbCommandGenerator _commandGenerator = new DbCommandGenerator();

        public void Generate(DbQuery source)
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
            DbQuery source
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