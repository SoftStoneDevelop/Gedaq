using Gedaq.Base.Model;
using Gedaq.Constants;
using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Immutable;

namespace Gedaq.Npgsql.Model
{
    internal class NpgsqlParametr : BaseParametr
    {
        public int Position;
        public bool HavePosition => Position != -1;

        public int NpgSqlDbType;
        public bool HaveNpgSqlDbType => NpgSqlDbType != 40;

        public override string VariableName(string postfix = default)
        {
            if (HaveNameInMethod)
            {
                return $"{NameInMethod}{postfix}";
            }

            return HaveNameInCommand ?
                    $"{NameInCommand}{postfix}" :
                    $"mParametr{Index}{postfix}";
        }

        internal static bool CreateNew(
            SourceProductionContext context,
            ImmutableArray<TypedConstant> namedArguments,
            out NpgsqlParametr parametr)
        {
            parametr = null;

            if (namedArguments.Length != 13)
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametrsCount,
                    DiagnosticConstants.IncorrectAttributeParametrsCountDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "Parametr", "13", namedArguments.Length.ToString() });

                return false;
            }

            var result = new NpgsqlParametr();
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

            if(!SetNpgSqlDbType(namedArguments[2], result))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "3", nameof(NpgSqlDbType) });

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

            if (!SetPosition(namedArguments[6], result))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "7", nameof(Position) });

                return false;
            }

            if (!SetSourceColumn(namedArguments[7], result))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "8", nameof(SourceColumn) });

                return false;
            }

            if (!SetSourceColumnNullMapping(namedArguments[8], result))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "9", nameof(SourceColumnNullMapping) });

                return false;
            }

            if (!SetSourceVersion(namedArguments[9], result))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "10", nameof(SourceVersion) });

                return false;
            }

            if (!SetScale(namedArguments[10], result))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "11", nameof(Scale) });

                return false;
            }

            if (!SetPrecision(namedArguments[11], result))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "12", nameof(Precision) });

                return false;
            }

            if (!SetNameInMethod(namedArguments[12], result))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "13", nameof(NameInMethod) });

                return false;
            }

            if (result.HaveNameInCommand && result.HavePosition)
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.AmbiguityOfParameterNamePosition,
                    DiagnosticConstants.AmbiguityOfParameterNamePositionDescr,
                    DiagnosticSeverity.Error);

                return false;
            }

            if (!result.HaveNameInCommand && !result.HavePosition)
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.ParameterNotHavePosName,
                    DiagnosticConstants.ParameterNotHavePosNameDescr,
                    DiagnosticSeverity.Error);

                return false;
            }

            parametr = result;
            return true;
        }

        private static bool SetNpgSqlDbType(TypedConstant argument, NpgsqlParametr parametr)
        {
            if (argument.Kind != TypedConstantKind.Enum ||
                !(argument.Type is INamedTypeSymbol dbType) ||
                !dbType.IsAssignableFrom("NpgsqlTypes", "NpgsqlDbType"))
            {
                return false;
            }

            parametr.NpgSqlDbType = (int)argument.Value;
            return true;
        }

        protected static bool SetPosition(TypedConstant argument, NpgsqlParametr parametr)
        {
            if (!(argument.Type is INamedTypeSymbol sizeParam) ||
                sizeParam.Name != nameof(Int32))
            {
                return false;
            }

            parametr.Position = (int)argument.Value;
            return true;
        }
    }
}