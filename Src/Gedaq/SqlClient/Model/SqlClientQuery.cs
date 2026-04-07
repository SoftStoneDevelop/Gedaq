using Gedaq.Base.Model;
using Gedaq.Constants;
using Gedaq.Enums;
using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace Gedaq.SqlClient.Model
{
    internal class SqlClientQuery : QueryBaseCommand
    {
        public SqlClientParametr[] Parametrs;
        public SqlClientDynamicParametr DynamicParametrs;

        private SqlClientQuery()
        {
        }

        public override bool HaveParametrs()
        {
            return Parametrs?.Length > 0;
        }

        internal static bool CreateNew(
            SourceProductionContext context,
            ImmutableArray<TypedConstant> namedArguments,
            INamedTypeSymbol containsType,
            out SqlClientQuery method)
        {
            method = null;
            if (namedArguments.Length != 11)
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametrsCount,
                    DiagnosticConstants.IncorrectAttributeParametrsCountDescr,
                    DiagnosticSeverity.Error,
                    namedArguments.Length.ToString());

                return false;
            }

            var methodSource = new SqlClientQuery();
            if (!methodSource.FillQuery(namedArguments[1]))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "2", nameof(Query) });

                return false;
            }

            if (!methodSource.FillMapTypes(namedArguments[2]))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "3", nameof(MapTypes) });

                return false;
            }

            if (!methodSource.FillOverrideAliasPrefixs(namedArguments[3]))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "4", nameof(OverrideAliasPrefixs) });

                return false;
            }

            if (!methodSource.FillQueryType(namedArguments[5]))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "6", nameof(QueryType) });

                return false;
            }

            if (!methodSource.FillGenerate(namedArguments[6]))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "6", nameof(NeedGenerate) });

                return false;
            }

            methodSource.MethodInfo =
                new BaseMethodInfo(
                    namedArguments[0],
                    namedArguments[4],
                    namedArguments[7],
                    namedArguments[8],
                    containsType);

            if (!methodSource.HaveMapTypes && methodSource.QueryType.HasFlag(QueryType.Read))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    $"For the '{nameof(QueryType.Read)}' type, the mapping type must be specified",
                    DiagnosticSeverity.Error);

                return false;
            }

            methodSource.ContainTypeName = containsType;
            method = methodSource;

            if (!methodSource.SetPartInterfaceType(namedArguments[9]))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "10", nameof(PartInterfaceType) });

                return false;
            }

            if (!methodSource.FillReturnType(namedArguments[10]))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    DiagnosticConstants.IncorrectAttributeParametrDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "11", nameof(ReturnType) });

                return false;
            }

            return true;
        }

        public override IEnumerable<BaseParametr> BaseParametrs()
        {
            return Parametrs;
        }

        public override BaseDynamicParametr BaseDynamicParametrs()
        {
            return DynamicParametrs;
        }

        public override bool HaveDynamicParametrs()
        {
            return DynamicParametrs != null;
        }
    }
}