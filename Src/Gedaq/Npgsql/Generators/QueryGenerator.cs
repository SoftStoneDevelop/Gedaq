using Gedaq.DbConnection.Generators;
using Gedaq.DbConnection.Model;
using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.Npgsql.Enums;
using Gedaq.Npgsql.Helpers;
using Gedaq.Npgsql.Model;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Gedaq.Npgsql.Generators
{
    internal class QueryGenerator : QueryBaseGenerator
    {
        NpgsqlQueryRead _queryReadGenerator = new NpgsqlQueryRead();
        NpgsqlQueryScalarAndNonQuery _queryScalarAndNonQuery = new NpgsqlQueryScalarAndNonQuery();
        NpgsqlCommandGenerator _commandGenerator = new NpgsqlCommandGenerator();

        public void GenerateMethod(QueryReadNpgsql source)
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
            QueryReadNpgsql source
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