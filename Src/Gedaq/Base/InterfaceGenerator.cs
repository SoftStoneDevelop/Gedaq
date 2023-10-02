using Gedaq.DbConnection.GeneratorsQuery;
using Gedaq.Enums;
using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;
using System.Text;

namespace Gedaq.Base
{
    internal class InterfaceGenerator
    {
        private List<string> _methodDefinitions = new List<string>();
        private StringBuilder _builder = new StringBuilder();

        public void GenerateAndSave(
            SourceProductionContext context,
            ITypeSymbol partInterfaceType,
            string usings,
            string partName
            )
        {
            if(_methodDefinitions.Count == 0)
            {
                return;
            }

            AccessModifier GetAccessModifier()
            {
                if (partInterfaceType.DeclaredAccessibility == Accessibility.Private)
                {
                    return AccessModifier.Private;
                }

                if (partInterfaceType.DeclaredAccessibility == Accessibility.Protected)
                {
                    return AccessModifier.Protected;
                }

                if (partInterfaceType.DeclaredAccessibility == Accessibility.Internal)
                {
                    return AccessModifier.Internal;
                }

                return AccessModifier.Public;
            }

            var accessModifier = GetAccessModifier();
            _builder.Append($@"
{usings}

namespace {partInterfaceType.ContainingNamespace.GetFullNamespace()}
{{
    {accessModifier.ToLowerInvariant()} partial interface {partInterfaceType.Name}
    {{
");
            foreach (var methodDefinition in _methodDefinitions)
            {
                _builder.Append(methodDefinition);
                _builder.Append(';');
                _builder.AppendLine();
            }
            _builder.Append($@"
    }}
}}
");
            context.AddSource($"{partName}{partInterfaceType.Name}.g.cs", _builder.ToString());
        }

        public void Reset()
        {
            _methodDefinitions.Clear();
            _builder.Clear();
        }

        public StringBuilder DefinitionBuilder()
        {
            return _builder;
        }

        public void AddMethodDefinition()
        {
            _methodDefinitions.Add(_builder.ToString());
            _builder.Clear();
        }
    }
}