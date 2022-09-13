using Gedaq.Enums;
using Gedaq.TypeWrappers;
using Microsoft.CodeAnalysis;
using System;
using System.Linq;

namespace Gedaq.Helpers
{
    internal static class PostgresModelHelper
    {
        internal static void FillModel(
            in ModelWrapper model,
            in AttributeData tableAttribute
            )
        {
            if (tableAttribute.ConstructorArguments.First().Type.Name != nameof(System.String))
            {
                throw new System.Exception($"Table name parameter type is not string: {model.Type.Name}");
            }

            var tableName = (string)tableAttribute.ConstructorArguments.First().Value;
            if (string.IsNullOrWhiteSpace(tableName))
            {
                throw new System.Exception($"Table name cannot be empty: {model.Type.Name}");
            }

            model.TableName.Add(Enums.ProviderDialect.PostgresSQL, tableName);

            if (!model.Type.Constructors.Any(an => an.Parameters.Length == 0))
            {
                throw new Exception($"The type '{model.Type.Name}' must have a parameterless constructor");
            }

            foreach (var member in model.Type.GetMembers())
            {
                if (!member.Kind.HasFlag(SymbolKind.Property) && !member.Kind.HasFlag(SymbolKind.Field))
                {
                    continue;
                }

                if (member is Microsoft.CodeAnalysis.IPropertySymbol propertySymbol)
                {
                    ProcessProperty(in model, in propertySymbol);
                    continue;
                }

                if (member is Microsoft.CodeAnalysis.IFieldSymbol fieldSymbol)
                {
                    ProcessField(in model, in fieldSymbol);
                    continue;
                }
            }
        }

        private static void ProcessProperty(
            in ModelWrapper model,
            in Microsoft.CodeAnalysis.IPropertySymbol propertySymbol
            )
        {
            if (propertySymbol.Type.IsAbstract)
            {
                throw new Exception($"Model '{model.Type.Name}'. Abstract type are not supported, property name: '{propertySymbol.Name}'");
            }

            if (propertySymbol.Type.IsRecord)
            {
                throw new Exception($"Model '{model.Type.Name}'. Record type are not supported, property name: '{propertySymbol.Name}'");
            }

            if (propertySymbol.Type is INamedTypeSymbol namedTypeSymbol && namedTypeSymbol.IsGenericType)
            {
                throw new Exception($"Model '{model.Type.Name}'. Generic property not supported. Property name: '{propertySymbol.Name}'");
            }

            if (!propertySymbol.DeclaredAccessibility.HasFlag(Accessibility.Public))
            {
                throw new Exception($"Property of model '{model.Type.Name}' must be a the public property. Property name: '{propertySymbol.Name}'");
            }

            if (propertySymbol.GetMethod == null)
            {
                throw new Exception($"Property of model '{model.Type.Name}' must have GetMethod. Property name: '{propertySymbol.Name}'");
            }

            if (!propertySymbol.GetMethod.DeclaredAccessibility.HasFlag(Accessibility.Public))
            {
                throw new Exception($"Model '{model.Type.Name}'. GetMethod must be public. Property name: '{propertySymbol.Name}'");
            }

            if (propertySymbol.SetMethod == null)
            {
                throw new Exception($"Property of model '{model.Type.Name}' must have SetMethod. Property name: '{propertySymbol.Name}'");
            }

            if (!propertySymbol.SetMethod.DeclaredAccessibility.HasFlag(Accessibility.Public))
            {
                throw new Exception($"Model '{model.Type.Name}'. SetMethod must be public. Property name: '{propertySymbol.Name}'");
            }

            FillPropertyOrField(in model, propertySymbol, propertySymbol.Type);
        }

        private static void ProcessField(
            in ModelWrapper model,
            in Microsoft.CodeAnalysis.IFieldSymbol fieldSymbol
            )
        {
            if (fieldSymbol.Type.IsAbstract)
            {
                throw new Exception($"Model '{model.Type.Name}'. Abstract type are not supported, field name: '{fieldSymbol.Name}'");
            }

            if (fieldSymbol.Type.IsRecord)
            {
                throw new Exception($"Model '{model.Type.Name}'. Record type are not supported, field name: '{fieldSymbol.Name}'");
            }

            if (fieldSymbol.Type is INamedTypeSymbol namedTypeSymbol && namedTypeSymbol.IsGenericType)
            {
                throw new Exception($"Model '{model.Type.Name}'. Generic field not supported. Field name: '{fieldSymbol.Name}'");
            }

            if (!fieldSymbol.DeclaredAccessibility.HasFlag(Accessibility.Public))
            {
                if (fieldSymbol.IsImplicitlyDeclared)
                {
                    //is back generated field for property
                    return;
                }

                throw new Exception($"Field of model '{model.Type.Name}' must be a the public field. Field name: '{fieldSymbol.Name}'");
            }

            FillPropertyOrField(in model, fieldSymbol, fieldSymbol.Type);
        }

        private static void FillColumnInfo(
            in ModelWrapper model,
            in TypeWrappers.Model.Column column,
            in AttributeData columnAttribute
            )
        {
            if (columnAttribute.ConstructorArguments[0].Type.Name != nameof(System.String))
            {
                throw new System.Exception($"Column name parameter type is not string: {model.Type.Name}");
            }

            column.ColumnName.Add(Enums.ProviderDialect.PostgresSQL, (string)columnAttribute.ConstructorArguments[0].Value);

            if (columnAttribute.ConstructorArguments[1].Type.Name != "NpgsqlDbType")
            {
                throw new System.Exception($"Column type parameter type is not NpgsqlDbType: {model.Type.Name}");
            }

            column.ColumnType.Add(Enums.ProviderDialect.PostgresSQL, (NpgsqlDbType)((Int32)columnAttribute.ConstructorArguments[1].Value));
        }

        private static void FillPropertyOrField(
            in ModelWrapper model,
            in ISymbol propertyOrField,
            in ITypeSymbol type
            )
        {
            var propertyName = propertyOrField.Name;
            var column = model.Columns.FirstOrDefault(wh => wh.PropertyName == propertyName);
            if (column == null)
            {
                column = new TypeWrappers.Model.Column() { PropertyName = propertyName };
                model.Columns.Add(column);
            }

            foreach (var attribute in propertyOrField.GetAttributes())
            {
                if (attribute.AttributeClass.IsAssignableFrom("Gedaq.Npgsql.Attributes", "ColumnAttribute"))
                {
                    FillColumnInfo(in model, in column, in attribute);
                    continue;
                }

                //TODO add constrains and defaults
            }

            if (!column.ColumnType.ContainsKey(Enums.ProviderDialect.PostgresSQL))
            {
                var dbType = DialectHelper.ToNpgsqlDbType(type);
                column.ColumnType.Add(Enums.ProviderDialect.PostgresSQL, dbType);
                column.ColumnName.Add(Enums.ProviderDialect.PostgresSQL, propertyOrField.Name);
            }
        }
    }
}
