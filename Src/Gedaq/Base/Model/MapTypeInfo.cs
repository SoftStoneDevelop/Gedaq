using Gedaq.Constants;
using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using System;

namespace Gedaq.Base.Model
{
    internal class MapTypeInfo
    {
        public ITypeSymbol MapType { get; set; }

        public Aliases Aliases { get; set; }

        public void ParseAliasesFromType(SourceProductionContext context, ProviderInfo providerInfo)
        {
            var mapType = MapType;
            var attributes = mapType.GetAttributes();

            var alias = new Aliases();
            foreach (var attribute in attributes)
            {
                if (attribute.AttributeClass.IsAssignableFrom("Gedaq.Common.Attributes", "AliasPrefixAttribute"))
                {
                    var constructorArguments = attribute.ConstructorArguments;
                    if (constructorArguments.Length != 1)
                    {
                        DiagnosticHelper.ReportDiagnostic(
                            context,
                            DiagnosticConstants.IncorrectAttributeParametrsCount,
                            DiagnosticConstants.IncorrectAttributeParametrsCountDescr,
                            DiagnosticSeverity.Error,
                            constructorArguments.Length.ToString());
                    }

                    var prefixArgument = constructorArguments[0];
                    if (!(prefixArgument.Type is INamedTypeSymbol paramName) ||
                        paramName.Name != nameof(String))
                    {
                        DiagnosticHelper.ReportDiagnostic(
                            context,
                            DiagnosticConstants.IncorrectAttributeParametr,
                            DiagnosticConstants.IncorrectAttributeParametrDescr,
                            DiagnosticSeverity.Error,
                            new string[] { "1", "AliasPrefix" });
                    }

                    alias.Prefix = ((string)prefixArgument.Value).ToLowerInvariant();
                    break;
                }
            }

            foreach (var member in mapType.GetMembers())
            {
                if (!member.Kind.HasFlag(SymbolKind.Property))
                {
                    continue;
                }

                if (!(member is Microsoft.CodeAnalysis.IPropertySymbol propertySymbol))
                {
                    continue;
                }

                var propertyType = propertySymbol.Type;
                if (!providerInfo.IsKnownProviderType(propertyType) && !providerInfo.IsSpecialHandlerType(propertyType))
                {
                    // Dynamic queries do not support nested mapping
                    continue;
                }

                var pAttributes = propertySymbol.GetAttributes();
                string sqlName = null;
                int? position = null;
                string name = propertySymbol.Name;

                foreach (var pAttribute in pAttributes)
                {
                    if (!pAttribute.AttributeClass.IsAssignableFrom("Gedaq.Common.Attributes", "AliasAttribute"))
                    {
                        continue;
                    }

                    var constructorArguments = pAttribute.ConstructorArguments;
                    if (constructorArguments.Length != 1)
                    {
                        DiagnosticHelper.ReportDiagnostic(
                            context,
                            DiagnosticConstants.IncorrectAttributeParametrsCount,
                            DiagnosticConstants.IncorrectAttributeParametrsCountDescr,
                            DiagnosticSeverity.Error,
                            constructorArguments.Length.ToString());
                    }

                    var aliasArgument = constructorArguments[0];
                    if (!(aliasArgument.Type is INamedTypeSymbol paramName) ||
                        paramName.Name != nameof(String))
                    {
                        DiagnosticHelper.ReportDiagnostic(
                            context,
                            DiagnosticConstants.IncorrectAttributeParametr,
                            DiagnosticConstants.IncorrectAttributeParametrDescr,
                            DiagnosticSeverity.Error,
                            new string[] { "1", "Alias" });
                    }

                    sqlName = ((string)aliasArgument.Value).ToLowerInvariant();

                    break;
                }

                if (string.IsNullOrWhiteSpace(sqlName))
                {
                    sqlName = name.ToLowerInvariant();
                }

                alias.Fields.Add(new Field { Name = name, Position = position, SQLName = sqlName });
            }

            Aliases = alias;
        }
    }
}