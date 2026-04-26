using Gedaq.Base.Model;
using Gedaq.Constants;
using Gedaq.Helpers;
using Microsoft.CodeAnalysis;
using System.Linq;

namespace Gedaq.Base.Batch
{
    internal static class BatchCommonBase
    {
        public static void CheckOutCannotExist(
            QueryBatchCommand batch,
            SourceProductionContext context)
        {
            if (batch.HaveParametrs &&
                batch.BatchPartBases().Any(any => any.QueryBase.HaveParametrs() && any.QueryBase.BaseParametrs().Any(anyIn => anyIn.HaveDirection)))
            {
                DiagnosticHelper.ReportDiagnostic(
                    context,
                    DiagnosticConstants.NotAllowedOutParametr,
                    "Iterator and Async methods cannot have out parameter",
                    DiagnosticSeverity.Error);
            }
        }
    }
}