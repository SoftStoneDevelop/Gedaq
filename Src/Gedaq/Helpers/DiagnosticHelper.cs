using Gedaq.Constants;
using Microsoft.CodeAnalysis;

namespace Gedaq.Helpers
{
    internal static class DiagnosticHelper
    {
        internal static void ReportDiagnostic(
            SourceProductionContext context,
            string disgnocticId,
            string message,
            DiagnosticSeverity diagnosticSeverity,
            params string[] messageParameters)
        {
            try
            {
                var diagnostic = Diagnostic.Create(new DiagnosticDescriptor(
                    disgnocticId,
                    title: "Generation Failed",
                    messageFormat: message,
                    category: DiagnosticConstants.Source,
                    defaultSeverity: diagnosticSeverity,
                    isEnabledByDefault: true),
                    Location.None,
                    messageArgs: messageParameters);

                context.ReportDiagnostic(diagnostic);
            }
            catch
            {
                // ignore
            }
        }
    }
}
