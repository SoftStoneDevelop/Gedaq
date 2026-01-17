using Gedaq.Base.Model;
using Gedaq.Constants;
using Gedaq.Enums;
using Gedaq.Helpers;
using Gedaq.MySqlConnector.Enums;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace Gedaq.MySqlConnector.Model
{
    internal class MySqlConnectorQuery : QueryBaseCommand
    {
        public MySqlConnectorSourceType SourceType { get; private set; }
        public MySqlConnectorParametr[] Parametrs;

        private MySqlConnectorQuery()
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
            out MySqlConnectorQuery method)
        {
            method = null;
            if (namedArguments.Length != 11)
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametrsCount,
                    "The number of attribute parameters does not match",
                    DiagnosticSeverity.Error);

                return false;
            }

            var methodSource = new MySqlConnectorQuery();
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

            if (!methodSource.FillSourceType(namedArguments[4]))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    "Parameter 5 (SourceType) could not be parsed",
                    DiagnosticSeverity.Error);

                return false;
            }

            if (!methodSource.FillQueryType(namedArguments[5]))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    "Parameter 6 (QueryType) could not be parsed",
                    DiagnosticSeverity.Error);

                return false;
            }

            if (!methodSource.FillGenerate(namedArguments[6]))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    "Parameter 7 (Generate) could not be parsed",
                    DiagnosticSeverity.Error);

                return false;
            }

            methodSource.MethodInfo =
                new BaseMethodInfo(
                    namedArguments[0],
                    namedArguments[3],
                    namedArguments[7],
                    namedArguments[8],
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

            if (!methodSource.SetPartInterfaceType(namedArguments[9]))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    "Parameter 10 (PartInterfaceType) could not be parsed",
                    DiagnosticSeverity.Error);

                return false;
            }

            if (!methodSource.FillReturnType(namedArguments[10]))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    "Parameter 11 (ReturnType) could not be parsed",
                    DiagnosticSeverity.Error);

                return false;
            }

            return true;
        }

        public override IEnumerable<BaseParametr> BaseParametrs()
        {
            return Parametrs;
        }

        private bool FillSourceType(TypedConstant argument)
        {
            if (argument.Kind != TypedConstantKind.Enum ||
                !(argument.Type is INamedTypeSymbol namedTypeSymbol4) ||
                !namedTypeSymbol4.IsAssignableFrom("Gedaq.MySqlConnector.Enums", "SourceType")
                )
            {
                return false;
            }

            SourceType = (MySqlConnectorSourceType)argument.Value;
            return true;
        }
    }
}