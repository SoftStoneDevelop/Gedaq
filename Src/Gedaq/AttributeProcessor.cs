using Gedaq.Helpers;
using Gedaq.Npgsql;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Xml.Linq;

namespace Gedaq
{
    internal class AttributeProcessor
    {
        private NpgsqlAttributeProcessor _npgsqlProcessor = new NpgsqlAttributeProcessor();

        public void TryFillFrom(INamedTypeSymbol type)
        {
            CheckAttributes(type.GetAttributes(), type);
            foreach (var member in type.GetMembers())
            {
                if(!(member is IMethodSymbol methodSymbol))
                {
                    continue;
                }

                CheckAttributes(methodSymbol.GetAttributes(), type);
            }
        }

        private void CheckAttributes(ImmutableArray<AttributeData> attributes, INamedTypeSymbol containsType)
        {
            foreach (var attribute in attributes)
            {
                if (_npgsqlProcessor.Process(attribute, containsType))
                {
                    continue;
                }

                //another databases(include processor for common database IConnection source)
            }
        }

        public void GenerateAndSaveMethods(GeneratorExecutionContext context)
        {
            var builder = new StringBuilder();
            _npgsqlProcessor.GenerateAndSaveMethods(context);
        }
    }
}