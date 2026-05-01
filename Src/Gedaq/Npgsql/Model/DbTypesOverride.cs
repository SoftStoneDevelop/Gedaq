using Gedaq.Constants;
using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Immutable;

namespace Gedaq.Npgsql.Model
{
    internal class DbTypesOverride
    {
        public int[] NpgSqlDbTypes;

        public int IndexOfTypeMap;

        internal static bool CreateNew(
            SourceProductionContext context,
            ImmutableArray<TypedConstant> namedArguments,
            out DbTypesOverride parametr)
        {
            parametr = null;

            if (namedArguments.Length != 2)
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametrsCount,
                    DiagnosticConstants.IncorrectAttributeParametrsCountDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "DbTypesOverride", "2", namedArguments.Length.ToString() });

                return false;
            }

            var result = new DbTypesOverride();
            if (!SetIndexOfTypeMap(namedArguments[0], result))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "1", nameof(IndexOfTypeMap) });

                return false;
            }

            if (!FillNpgsqlDbTypes(namedArguments[1], result))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "2", nameof(NpgSqlDbTypes) });

                return false;
            }

            parametr = result;
            return true;
        }

        private static bool FillNpgsqlDbTypes(TypedConstant argument, DbTypesOverride model)
        {
            if (!(argument.Type is IArrayTypeSymbol arrayTypeSymbol) ||
                arrayTypeSymbol.Rank != 1 ||
                arrayTypeSymbol.ElementType.TypeKind != TypeKind.Enum ||
                !(arrayTypeSymbol.ElementType is INamedTypeSymbol elementType) ||
                !elementType.IsAssignableFrom("NpgsqlTypes", "NpgsqlDbType"))
            {
                return false;
            }

            if (argument.IsNull)
            {
                return false;
            }

            model.NpgSqlDbTypes = new int[argument.Values.Length];
            for (int i = 0; i < argument.Values.Length; i++)
            {
                model.NpgSqlDbTypes[i] = (int)argument.Values[i].Value;
            }

            return true;
        }

        protected static bool SetIndexOfTypeMap(TypedConstant argument, DbTypesOverride model)
        {
            if (!(argument.Type is INamedTypeSymbol indexParam) ||
                indexParam.Name != nameof(Int32))
            {
                return false;
            }

            model.IndexOfTypeMap = (int)argument.Value;
            return true;
        }
    }
}