using Gedaq.Helpers;
using Gedaq.Npgsql;
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
        }

        private void CompleteProcessContainTypes()
        {
            _npgsqlProcessor.CompleteProcessContainTypes();
        }

        public void GenerateAndSaveMethods(GeneratorExecutionContext context)
        {
            var builder = new StringBuilder();
            _npgsqlProcessor.GenerateAndSaveMethods(context);
        }
    }
}