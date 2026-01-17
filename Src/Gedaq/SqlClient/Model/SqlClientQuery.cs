using Gedaq.Base.Model;
using Gedaq.Constants;
using Gedaq.Enums;
using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace Gedaq.SqlClient.Model
{
    internal class SqlClientQuery : QueryBaseCommand
    {
        public SqlClientParametr[] Parametrs;

        private SqlClientQuery()
        {
        }

        public override bool HaveParametrs()
        {
            return Parametrs != null;
        }

        internal static bool CreateNew(
            SourceProductionContext context,
            ImmutableArray<TypedConstant> namedArguments,
            INamedTypeSymbol containsType,
            out SqlClientQuery method)
        {
            method = null;
            if (namedArguments.Length != 10)
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametrsCount,
                    "The number of attribute parameters does not match",
                    DiagnosticSeverity.Error);

                return false;
            }

            var methodSource = new SqlClientQuery();
            if (!methodSource.FillQuery(namedArguments[1]))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    "Parameter 2 (Query) could not be parsed",
                    DiagnosticSeverity.Error);

                return false;
            }

            if (!methodSource.FillMapType(namedArguments[2]))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    "Parameter 3 (MapType) could not be parsed",
                    DiagnosticSeverity.Error);

                return false;
            }

            if (!methodSource.FillQueryType(namedArguments[4]))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    "Parameter 5 (QueryType) could not be parsed",
                    DiagnosticSeverity.Error);

                return false;
            }

            if (!methodSource.FillGenerate(namedArguments[5]))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    "Parameter 6 (Generate) could not be parsed",
                    DiagnosticSeverity.Error);

                return false;
            }

            methodSource.MethodInfo =
                new BaseMethodInfo(
                    namedArguments[0],
                    namedArguments[3],
                    namedArguments[6],
                    namedArguments[7],
                    containsType);

            if (methodSource.MapTypeName == null && methodSource.QueryType.HasFlag(QueryType.Read))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    "For the 'Read' type, the mapping type must be specified",
                    DiagnosticSeverity.Error);

                return false;
            }

            methodSource.ContainTypeName = containsType;
            method = methodSource;
            if (!methodSource.SetPartInterfaceType(namedArguments[8]))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    "Parameter 9 (PartInterfaceType) could not be parsed",
                    DiagnosticSeverity.Error);

                return false;
            }

            if (!methodSource.FillReturnType(namedArguments[9]))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    "Parameter 10 (ReturnType) could not be parsed",
                    DiagnosticSeverity.Error);

                return false;
            }

            return true;
        }

        public override IEnumerable<BaseParametr> BaseParametrs()
        {
            return Parametrs;
        }
    }
}