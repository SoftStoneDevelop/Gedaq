using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.Parser;
using Gedaq.SqlClient.GeneratorsQuery;
using Gedaq.SqlClient.Model;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace Gedaq.SqlClient
{
    internal class SqlClientAttributeProcessor
    {
        private List<SqlClientQuery> _read = new List<SqlClientQuery>();

        Dictionary<string, SqlClientQuery> _readTemp = new Dictionary<string, SqlClientQuery>();
        Dictionary<string, List<SqlClientParametr>> _parametrsTemp = new Dictionary<string, List<SqlClientParametr>>();

        private QueryParser _queryParser = new QueryParser();

        public bool ProcessAttributes(ImmutableArray<AttributeData> attributes, INamedTypeSymbol containsType)
        {
            foreach (var attribute in attributes)
            {
                if (attribute.AttributeClass.IsAssignableFrom("Gedaq.SqlClient.Attributes", "QueryAttribute"))
                {
                    ProcessQueryRead(attribute, containsType);
                    continue;
                }

                if (attribute.AttributeClass.IsAssignableFrom("Gedaq.SqlClient.Attributes", "ParametrAttribute"))
                {
                    ProcessParametr(attribute, containsType);
                    continue;
                }
            }

            return false;
        }

        public void CompleteProcessContainTypes()
        {
            FillReadMethods();
            _parametrsTemp.Clear();

            _readTemp.Clear();
        }

        private void FillReadMethods()
        {
            foreach (var read in _readTemp.Values)
            {
                if (_parametrsTemp.TryGetValue(read.MethodName, out var parametrs))
                {
                    read.Parametrs = parametrs.ToArray();
                }

                if (read.QueryType == QueryType.Read)
                {
                    read.Aliases = _queryParser.Parse(ref read.Query);
                }
                else
                {
                    read.Aliases = _queryParser.GetIntResultAlias();
                }

                if (read.NeedGenerate)
                {
                    _read.Add(read);
                }
            }
        }

        private void ProcessQueryRead(AttributeData queryReadAttribute, INamedTypeSymbol containsType)
        {
            if (!SqlClientQuery.CreateNew(queryReadAttribute.ConstructorArguments, containsType, out var queryReadMethod))
            {
                throw new Exception($"Unknown {nameof(SqlClientQuery)} constructor");
            }

            if(_readTemp.ContainsKey(queryReadMethod.MethodName))
            {
                throw new Exception("Request with duplicate name");
            }

            _readTemp[queryReadMethod.MethodName] = queryReadMethod;
        }

        private void ProcessParametr(AttributeData parametrAttribute, INamedTypeSymbol containsType)
        {
            if (!SqlClientParametr.CreateNew(parametrAttribute.ConstructorArguments, containsType, out var parametr, out var methodName))
            {
                throw new Exception($"Unknown {nameof(SqlClientParametr)} constructor");
            }

            if (!_parametrsTemp.ContainsKey(methodName))
            {
                var methods = new List<SqlClientParametr>();
                _parametrsTemp.Add(methodName, methods);
            }

            _parametrsTemp[methodName].Add(parametr);
        }

        public void GenerateAndSaveMethods(GeneratorExecutionContext context)
        {
            var readGenerator = new SqlClientQueryGenerator();
            foreach (var queryRead in _read)
            {
                readGenerator.Generate(queryRead);
                context.AddSource($"{queryRead.MethodName}SqlClientExtension.g.cs", readGenerator.GetCode());
            }
            _read.Clear();
        }
    }
}