using Gedaq.Constants;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gedaq.Helpers
{
    internal static class DiagnosticHelper
    {
        internal static void ReportDiagnostic(
            SourceProductionContext context,
            string disgnocticId,
            string message,
            DiagnosticSeverity diagnosticSeverity)
        {
            try
            {
                var diagnostic = Diagnostic.Create(new DiagnosticDescriptor(
                    disgnocticId,
                    string.Empty,
                    message,
                    DiagnosticConstants.Source,
                    diagnosticSeverity,
                    true),
                    null);

                context.ReportDiagnostic(diagnostic);
            }
            catch
            {
                // ignore
            }
        }
    }
}
