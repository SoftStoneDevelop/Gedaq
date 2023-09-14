using Gedaq.MySqlConnector;
using Gedaq.Npgsql;
using Gedaq.SqlClient;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Threading;

namespace Gedaq
{
    internal class AttributeProcessor
    {
        private NpgsqlAttributeProcessor _npgsqlProcessor = new NpgsqlAttributeProcessor();
        private DbConnectionAttributeProcessor _dbConnectionProcessor = new DbConnectionAttributeProcessor();
        private SqlClientAttributeProcessor _sqlClientProcessor = new SqlClientAttributeProcessor();
        private MySqlConnectorAttributeProcessor _mysqlConnectorProcessor = new MySqlConnectorAttributeProcessor();

        public void TryFillFrom(
            TypeDeclarationSyntax type,
            Compilation compilation, 
            INamedTypeSymbol containsType,
            CancellationToken cancellationToken
            )
        {
            cancellationToken.ThrowIfCancellationRequested();
            ProcessAttributes(type.AttributeLists, compilation, containsType, cancellationToken);
            foreach (var member in type.Members)
            {
                cancellationToken.ThrowIfCancellationRequested();
                if (!(member is MethodDeclarationSyntax methodSymbol))
                {
                    continue;
                }

                ProcessAttributes(methodSymbol.AttributeLists, compilation, containsType, cancellationToken);
            }
        }

        private void ProcessAttributes(
            SyntaxList<AttributeListSyntax> attributes, 
            Compilation compilation, 
            INamedTypeSymbol containsType,
            CancellationToken cancellationToken
            )
        {
            _npgsqlProcessor.ProcessAttributes(attributes, compilation, containsType, cancellationToken);
            _dbConnectionProcessor.ProcessAttributes(attributes, compilation, containsType, cancellationToken);
            _sqlClientProcessor.ProcessAttributes(attributes, compilation, containsType, cancellationToken);
            _mysqlConnectorProcessor.ProcessAttributes(attributes, compilation, containsType, cancellationToken);
        }

        public void CompleteProcessContainTypes()
        {
            _npgsqlProcessor.CompleteProcessContainTypes();
            _dbConnectionProcessor.CompleteProcessContainTypes();
            _sqlClientProcessor.CompleteProcessContainTypes();
            _mysqlConnectorProcessor.CompleteProcessContainTypes();
        }

        public void GenerateAndSaveMethods(SourceProductionContext context, CancellationToken cancellationToken)
        {
            _npgsqlProcessor.GenerateAndSaveMethods(context, cancellationToken);
            _dbConnectionProcessor.GenerateAndSaveMethods(context, cancellationToken);
            _sqlClientProcessor.GenerateAndSaveMethods(context, cancellationToken);
            _mysqlConnectorProcessor.GenerateAndSaveMethods(context, cancellationToken);
        }
    }
}