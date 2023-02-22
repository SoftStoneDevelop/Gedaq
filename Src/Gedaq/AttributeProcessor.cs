using Gedaq.DbConnection;
using Gedaq.Helpers;
using Gedaq.Npgsql;
using Gedaq.SqlClient;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Linq;

namespace Gedaq
{
    internal class AttributeProcessor
    {
        private NpgsqlAttributeProcessor _npgsqlProcessor = new NpgsqlAttributeProcessor();
        private DbConnectionAttributeProcessor _dbConnectionProcessor = new DbConnectionAttributeProcessor();
        private SqlClientAttributeProcessor _sqlClientProcessor = new SqlClientAttributeProcessor();

        public void TryFillFrom(INamedTypeSymbol type)
        {
            ProcessAttributes(type.GetAttributes(), type);
            foreach (var member in type.GetMembers())
            {
                if(!(member is IMethodSymbol methodSymbol))
                {
                    continue;
                }

                ProcessAttributes(methodSymbol.GetAttributes(), type);
            }

            CompleteProcessContainTypes();
        }

        private void ProcessAttributes(ImmutableArray<AttributeData> attributes, INamedTypeSymbol containsType)
        {
            _npgsqlProcessor.ProcessAttributes(attributes, containsType);
            _dbConnectionProcessor.ProcessAttributes(attributes, containsType);
            _sqlClientProcessor.ProcessAttributes(attributes, containsType);
        }

        private void CompleteProcessContainTypes()
        {
            _npgsqlProcessor.CompleteProcessContainTypes();
            _dbConnectionProcessor.CompleteProcessContainTypes();
            _sqlClientProcessor.CompleteProcessContainTypes();
        }

        public void GenerateAndSaveMethods(GeneratorExecutionContext context)
        {
            _npgsqlProcessor.GenerateAndSaveMethods(context);
            _dbConnectionProcessor.GenerateAndSaveMethods(context);
            _sqlClientProcessor.GenerateAndSaveMethods(context);
        }
    }
}