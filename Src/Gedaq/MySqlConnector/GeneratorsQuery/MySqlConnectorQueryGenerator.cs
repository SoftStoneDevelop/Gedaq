using Gedaq.Base;
using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.MySqlConnector.Model;

namespace Gedaq.MySqlConnector.GeneratorsQuery
{
    internal class MySqlConnectorQueryGenerator : BaseGenerator
    {
        private readonly MySqlConnectorCommand _commandGenerator;
        private readonly MySqlConnectorQueryRead _queryReadGenerator;
        private readonly MySqlConnectorQueryScalarAndNonQuery _queryScalarAndNonQuery;

        public MySqlConnectorQueryGenerator()
        {
            _commandGenerator = new MySqlConnectorCommand();
            _queryReadGenerator = new MySqlConnectorQueryRead(_commandGenerator);
            _queryScalarAndNonQuery = new MySqlConnectorQueryScalarAndNonQuery(_commandGenerator);
        }

        public void GenerateMethod(MySqlConnectorQuery source)
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
            MySqlConnectorQuery source
            )
        {
            _methodCode.Append($@"
using MySqlConnector;
using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace {source.ContainTypeName.ContainingNamespace}
{{
    {GeneratedClassDeclarationHelper.GCDeclarationName(source.ContainTypeName, source.MethodInfo, "MySqlConnector")}
    {{
");
        }
    }
}