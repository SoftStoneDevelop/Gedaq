using Gedaq.Constants;
using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Immutable;

namespace Gedaq.Base.Model
{
    internal class FormatParametr
    {
        public string Name;
        public int Position;

        internal static bool CreateNew(
            SourceProductionContext context,
            ImmutableArray<TypedConstant> namedArguments,
            out FormatParametr format)
        {
            format = null;

            if (namedArguments.Length != 2)
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametrsCount,
                    DiagnosticConstants.IncorrectAttributeParametrsCountDescr,
                    DiagnosticSeverity.Error,
                    new string[] { "Format", "2", namedArguments.Length.ToString() });

                return false;
            }

            var result = new FormatParametr();
            if (!SetPosition(namedArguments[0], result))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    $"Parameter 1 (Position) for QueryFormat could not be parsed",
                    DiagnosticSeverity.Error);

                return false;
            }

            if (!SetName(namedArguments[1], result))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.IncorrectAttributeParametr,
                    $"Parameter 2 (Name) for QueryFormat could not be parsed",
                    DiagnosticSeverity.Error);

                return false;
            }

            format = result;
            return true;
        }

        protected static bool SetName(TypedConstant argument, FormatParametr parametr)
        {
            if (!(argument.Type is INamedTypeSymbol strParam) ||
                strParam.Name != nameof(String))
            {
                return false;
            }

            parametr.Name = (string)argument.Value;
            return true;
        }

        protected static bool SetPosition(TypedConstant argument, FormatParametr parametr)
        {
            if (!(argument.Type is INamedTypeSymbol sizeParam) ||
                sizeParam.Name != nameof(Int32))
            {
                return false;
            }

            parametr.Position = (int)argument.Value;
            return true;
        }

        public void CalculateDatas(int index)
        {
            CalculateName(index);
        }

        private void CalculateName(int index)
        {
            if(Name != null)
            {
                return;
            }

            Name = $"format{index}";
        }
    }
}