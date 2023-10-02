using Gedaq.Base;
using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.Npgsql.Model;

namespace Gedaq.Npgsql.GeneratorsQuery
{
    internal class NpgsqlQueryGenerator : BaseGenerator
    {
        private readonly NpgsqlQueryRead _queryReadGenerator;
        private readonly NpgsqlQueryScalarAndNonQuery _queryScalarAndNonQuery;
        private readonly NpgsqlCommand _commandGenerator;

        public NpgsqlQueryGenerator()
        {
            _commandGenerator = new NpgsqlCommand();
            _queryReadGenerator = new NpgsqlQueryRead(_commandGenerator);
            _queryScalarAndNonQuery = new NpgsqlQueryScalarAndNonQuery(_commandGenerator);
        }

        public void GenerateMethod(NpgsqlQuery source, InterfaceGenerator interfaceGenerator)
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
            return @"using Npgsql;
using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;";
        }

        private void Start(
            NpgsqlQuery source
            )
        {
            _methodCode.Append($@"
{Usings()}

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