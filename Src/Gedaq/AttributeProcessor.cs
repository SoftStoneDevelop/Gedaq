using Gedaq.MySqlConnector;
using Gedaq.Npgsql;
using Gedaq.SqlClient;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Immutable;
using System.Linq;

namespace Gedaq
{
    internal class AttributeProcessor
    {
        private NpgsqlAttributeProcessor _npgsqlProcessor = new NpgsqlAttributeProcessor();
        private DbConnectionAttributeProcessor _dbConnectionProcessor = new DbConnectionAttributeProcessor();
        private SqlClientAttributeProcessor _sqlClientProcessor = new SqlClientAttributeProcessor();
        private MySqlConnectorAttributeProcessor _mysqlConnectorProcessor = new MySqlConnectorAttributeProcessor();

        public void TryFillFrom(TypeDeclarationSyntax type, Compilation compilation, INamedTypeSymbol containsType)
        {
            ProcessAttributes(type.AttributeLists, compilation, containsType);
            foreach (var member in type.Members)
            {
                if(!(member is MethodDeclarationSyntax methodSymbol))
                {
                    continue;
                }

                ProcessAttributes(methodSymbol.AttributeLists, compilation, containsType);
            }
        }

        private void ProcessAttributes(SyntaxList<AttributeListSyntax> attributes, Compilation compilation, INamedTypeSymbol containsType)
        {
            _npgsqlProcessor.ProcessAttributes(attributes, compilation, containsType);
            _dbConnectionProcessor.ProcessAttributes(attributes, compilation, containsType);
            _sqlClientProcessor.ProcessAttributes(attributes, compilation, containsType);
            _mysqlConnectorProcessor.ProcessAttributes(attributes, compilation, containsType);
        }

        public void CompleteProcessContainTypes()
        {
            _npgsqlProcessor.CompleteProcessContainTypes();
            _dbConnectionProcessor.CompleteProcessContainTypes();
            _sqlClientProcessor.CompleteProcessContainTypes();
            _mysqlConnectorProcessor.CompleteProcessContainTypes();
        }

        public void GenerateAndSaveMethods(SourceProductionContext context)
        {
            _npgsqlProcessor.GenerateAndSaveMethods(context);
            _dbConnectionProcessor.GenerateAndSaveMethods(context);
            _sqlClientProcessor.GenerateAndSaveMethods(context);
            _mysqlConnectorProcessor.GenerateAndSaveMethods(context);
        }
    }
}