using Gedaq.Constants;
using Gedaq.Helpers;
using Gedaq.Npgsql.Model;
using Microsoft.CodeAnalysis;
using System;

namespace Gedaq.Base.Model
{
    internal class MapTypeInfo
    {
        internal MapTypeInfo(int orderMap)
        {
            OrderMap = orderMap;
        }

        public ITypeSymbol MapType { get; set; }

        public Aliases Aliases { get; set; }

        public int OrderMap { get; private set; }

        public string MapItemName => $"mapItem{OrderMap}";

        public string ItemTypeName => MapType.GetFullTypeName(true);

        public void ParseAliasesFromType(
            SourceProductionContext context,
            string overrideAlias = null)
        {
            var mapType = MapType;
            var attributes = mapType.GetAttributes();

            var alias = new Aliases();
            if (overrideAlias != null)
            {
                alias.Prefix = overrideAlias;
            }
            else
            {
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
                                new string[] { "AliasPrefix", "1", constructorArguments.Length.ToString() });
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
                var pAttributes = propertySymbol.GetAttributes();
                string sqlName = null;
                int? position = null;
                string name = propertySymbol.Name;
                NpgsqlFieldInfo additionalInfo = null;

                foreach (var pAttribute in pAttributes)
                {
                    if (pAttribute.AttributeClass.IsAssignableFrom("Gedaq.Common.Attributes", "IgnorePropertyAttribute"))
                    {
                        continue;
                    }

                    if (pAttribute.AttributeClass.IsAssignableFrom("Gedaq.Common.Attributes", "AliasAttribute"))
                    {
                        var constructorArguments = pAttribute.ConstructorArguments;
                        if (constructorArguments.Length != 2)
                        {
                            DiagnosticHelper.ReportDiagnostic(
                                context,
                                DiagnosticConstants.IncorrectAttributeParametrsCount,
                                DiagnosticConstants.IncorrectAttributeParametrsCountDescr,
                                DiagnosticSeverity.Error,
                                new string[] { "Alias", "2", constructorArguments.Length.ToString() });
                        }

                        var aliasArgument = constructorArguments[0];
                        if (!(aliasArgument.Type is INamedTypeSymbol paramName)
                            || paramName.Name != nameof(String))
                        {
                            DiagnosticHelper.ReportDiagnostic(
                                context,
                                DiagnosticConstants.IncorrectAttributeParametr,
                                DiagnosticConstants.IncorrectAttributeParametrDescr,
                                DiagnosticSeverity.Error,
                                new string[] { "1", "Alias" });
                        }

                        sqlName = ((string)aliasArgument.Value).ToLowerInvariant();

                        var orderArgument = constructorArguments[1];
                        if (!(orderArgument.Type is INamedTypeSymbol orderParam) || orderParam.Name != nameof(Int32))
                        {
                            DiagnosticHelper.ReportDiagnostic(
                                context,
                                DiagnosticConstants.IncorrectAttributeParametr,
                                DiagnosticConstants.IncorrectAttributeParametrDescr,
                                DiagnosticSeverity.Error,
                                new string[] { "1", "Alias" });
                        }
                        else
                        {
                            var orderValue = (int)orderArgument.Value; ;
                            position = orderValue == -1 ? (int?)null : orderValue;
                        }

                        continue;
                    }

                    if (pAttribute.AttributeClass.IsAssignableFrom("Gedaq.Npgsql.Attributes", "DbTypeAttribute"))
                    {
                        var constructorArguments = pAttribute.ConstructorArguments;
                        if (constructorArguments.Length != 1)
                        {
                            DiagnosticHelper.ReportDiagnostic(
                                context,
                                DiagnosticConstants.IncorrectAttributeParametrsCount,
                                DiagnosticConstants.IncorrectAttributeParametrsCountDescr,
                                DiagnosticSeverity.Error,
                                new string[] { "DbType", "1", constructorArguments.Length.ToString() });
                        }

                        var dbTypeArgument = constructorArguments[0];
                        if (dbTypeArgument.Type.TypeKind != TypeKind.Enum
                            || !(dbTypeArgument.Type is INamedTypeSymbol elementType)
                            || !elementType.IsAssignableFrom("NpgsqlTypes", "NpgsqlDbType"))
                        {
                            DiagnosticHelper.ReportDiagnostic(
                                context,
                                DiagnosticConstants.IncorrectAttributeParametr,
                                DiagnosticConstants.IncorrectAttributeParametrDescr,
                                DiagnosticSeverity.Error,
                                new string[] { "1", "DbType" });
                        }
                        else
                        {
                            additionalInfo = new NpgsqlFieldInfo((int)dbTypeArgument.Value);
                        }

                        continue;
                    }
                }

                if (string.IsNullOrWhiteSpace(sqlName) && position.HasValue)
                {
                    sqlName = name.ToLowerInvariant();
                }

                alias.AddField(
                    new Field
                    {
                        Name = name,
                        Position = position,
                        SQLName = sqlName,
                        AdditionalInfo = additionalInfo,
                    });
            }

            Aliases = alias;
        }
    }
}