using Gedaq.Base;
using Gedaq.Base.Model;
using Gedaq.Constants;
using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using System.Collections.Immutable;

namespace Gedaq.Npgsql.Model
{
    internal class BinaryImport : BinaryCopyBase
    {
        private BinaryImport()
        {
        }

        internal static bool CreateNew(
            SourceProductionContext context,
            ImmutableArray<TypedConstant> namedArguments,
            INamedTypeSymbol containsType,
            ProviderInfo providerInfo,
            out BinaryImport method)
        {
            method = null;
            if (namedArguments.Length != 9)
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametrsCount,
                    DiagnosticConstants.IncorrectAttributeParametrsCountDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "BinaryImport", "9", namedArguments.Length.ToString() });

                return false;
            }

            var methodSource = new BinaryImport();
            if (!methodSource.FillQuery(namedArguments[0]))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "1", nameof(Query) });

                return false;
            }

            if (!methodSource.FillNpgsqlDbTypes(namedArguments[3]))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "4", nameof(_npgSqlDbTypes) });

                return false;
            }

            if (!methodSource.FillMapTypesFromSingle(namedArguments[2], providerInfo))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "3", nameof(MapTypeInfos) });

                return false;
            }

            if (!methodSource.FillSourceType(namedArguments[5]))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "6", nameof(SourceType) });

                return false;
            }

            methodSource.MethodInfo =
                new BaseMethodInfo(
                    methodName: namedArguments[1],
                    methodType: namedArguments[4],
                    accessModifier: namedArguments[6],
                    asyncResultType: namedArguments[7],
                    containsType: containsType);

            if (!methodSource.HaveMapTypes)
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.UnknownMapTypes,
                    DiagnosticConstants.UnknownMapTypesDescr,
                    DiagnosticSeverity.Error);
            }

            methodSource.ContainTypeName = containsType;
            method = methodSource;
            if (!methodSource.SetPartInterfaceType(namedArguments[8]))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "9", nameof(PartInterfaceType) });

                return false;
            }

            return true;
        }
    }
}