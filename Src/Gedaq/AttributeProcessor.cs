using Gedaq.DbConnection;
using Gedaq.MySqlConnector;
using Gedaq.Npgsql;
using Gedaq.SqlClient;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Gedaq
{
    internal class AttributeProcessor
    {
        private readonly NpgsqlProviderInfo _npgsqlProviderInfo;
        private readonly NpgsqlAttributeProcessor _npgsqlProcessor;

        private readonly DbProviderInfo _dbProviderInfo;
        private readonly DbConnectionAttributeProcessor _dbConnectionProcessor;

        private readonly SqlClientProviderInfo _sqlClientProviderInfo;
        private readonly SqlClientAttributeProcessor _sqlClientProcessor;

        private readonly MySqlConnectorProviderInfo _mySqlConnectorProviderInfo;
        private readonly MySqlConnectorAttributeProcessor _mysqlConnectorProcessor;

        public AttributeProcessor(SourceProductionContext context)
        {
            _npgsqlProviderInfo = new NpgsqlProviderInfo();
            _npgsqlProcessor = new NpgsqlAttributeProcessor(context, _npgsqlProviderInfo);

            _dbProviderInfo = new DbProviderInfo();
            _dbConnectionProcessor = new DbConnectionAttributeProcessor(context, _dbProviderInfo);

            _sqlClientProviderInfo = new SqlClientProviderInfo();
            _sqlClientProcessor = new SqlClientAttributeProcessor(context, _sqlClientProviderInfo);

            _mySqlConnectorProviderInfo = new MySqlConnectorProviderInfo();
            _mysqlConnectorProcessor = new MySqlConnectorAttributeProcessor(context, _mySqlConnectorProviderInfo);
        }

        public void TryFillFrom(
            TypeDeclarationSyntax type,
            Compilation compilation, 
            INamedTypeSymbol containsType)
        {
            ProcessAttributes(type.AttributeLists, compilation, containsType);
            foreach (var member in type.Members)
            {
                if (!(member is MethodDeclarationSyntax methodSymbol))
                {
                    continue;
                }

                ProcessAttributes(methodSymbol.AttributeLists, compilation, containsType);
            }
        }

        private void ProcessAttributes(
            SyntaxList<AttributeListSyntax> attributes, 
            Compilation compilation, 
            INamedTypeSymbol containsType)
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

        public void GenerateAndSaveMethods()
        {
            _npgsqlProcessor.GenerateAndSaveMethods();
            _dbConnectionProcessor.GenerateAndSaveMethods();
            _sqlClientProcessor.GenerateAndSaveMethods();
            _mysqlConnectorProcessor.GenerateAndSaveMethods();
        }
    }
}