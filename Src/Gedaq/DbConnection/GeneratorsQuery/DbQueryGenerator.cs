using Gedaq.Base;
using Gedaq.DbConnection.Model;
using Gedaq.Enums;
using Gedaq.Helpers;

namespace Gedaq.DbConnection.GeneratorsQuery
{
    internal class DbQueryGenerator : BaseGenerator
    {
        private readonly DbCommandGenerator _commandGenerator;
        private readonly DbQueryRead _queryReadGenerator;
        private readonly DbQueryScalarAndNonQuery _queryScalarAndNonQuery;

        public DbQueryGenerator() 
        {
            _commandGenerator = new DbCommandGenerator();
            _queryReadGenerator = new DbQueryRead(_commandGenerator);
            _queryScalarAndNonQuery = new DbQueryScalarAndNonQuery(_commandGenerator);
        }

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
    {GeneratedClassDeclarationHelper.GCDeclarationName(source.ContainTypeName, source.MethodInfo, "DbConnection")}
    {{
");
        }
    }
}