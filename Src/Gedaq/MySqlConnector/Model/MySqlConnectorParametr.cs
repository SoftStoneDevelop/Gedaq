using Gedaq.Base.Model;
using Gedaq.Constants;
using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Immutable;

namespace Gedaq.MySqlConnector.Model
{
    internal class MySqlConnectorParametr : BaseParametr
    {
        public int MySqlDbType;
        public bool HaveMySqlDbType => MySqlDbType != 253;


        public override string VariableName(string postfix = default)
        {
            if (HaveNameInMethod)
            {
                return $"{NameInMethod}{postfix}";
            }

            return $"{NameInCommand}{postfix}";
        }

        internal static bool CreateNew(
            SourceProductionContext context,
            ImmutableArray<TypedConstant> namedArguments,
            out MySqlConnectorParametr parametr)
        {
            parametr = null;

            if (namedArguments.Length != 12)
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametrsCount,
                    DiagnosticConstants.IncorrectAttributeParametrsCountDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "Parametr", "12", namedArguments.Length.ToString() });

                return false;
            }

            var result = new MySqlConnectorParametr();
            if (!SetType(namedArguments[0], result))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "1", nameof(Type) });

                return false;
            }

            if (!SetNameInCommand(namedArguments[1], result))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "2", nameof(NameInCommand) });

                return false;
            }

            if (!SetSqlDbType(namedArguments[2], result))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "3", nameof(MySqlDbType) });

                return false;
            }

            if (!SetSize(namedArguments[3], result))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "4", nameof(Size) });

                return false;
            }

            if (!SetNullable(namedArguments[4], result))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "5", nameof(Nullable) });

                return false;
            }

            if (!SetDirection(namedArguments[5], result))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "6", nameof(Direction) });

                return false;
            }

            if (!SetSourceColumn(namedArguments[6], result))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "7", nameof(SourceColumn) });

                return false;
            }

            if (!SetSourceColumnNullMapping(namedArguments[7], result))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "8", nameof(SourceColumnNullMapping) });

                return false;
            }

            if (!SetSourceVersion(namedArguments[8], result))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "9", nameof(SourceVersion) });

                return false;
            }

            if (!SetScale(namedArguments[9], result))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "10", nameof(Scale) });

                return false;
            }

            if (!SetPrecision(namedArguments[10], result))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "11", nameof(Precision) });

                return false;
            }

            if (!SetNameInMethod(namedArguments[11], result))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "12", nameof(NameInMethod) });

                return false;
            }

            if (!result.HaveNameInCommand)
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.UnnamedQueryParametr,
                    DiagnosticConstants.UnnamedQueryParametrDescr,
                    DiagnosticSeverity.Error);
            }

            parametr = result;
            return true;
        }

        private static bool SetSqlDbType(TypedConstant argument, MySqlConnectorParametr parametr)
        {
            if (argument.Kind != TypedConstantKind.Enum ||
                !(argument.Type is INamedTypeSymbol dbType) ||
                !dbType.IsAssignableFrom("MySqlConnector", "MySqlDbType"))
            {
                return false;
            }

            parametr.MySqlDbType = (int)argument.Value;
            return true;
        }
    }
}