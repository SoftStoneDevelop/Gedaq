using Gedaq.Enums;

namespace Gedaq.Helpers
{
    internal static class AsyncResultHelper
    {
        internal static string ToResultType(this AsyncResult asyncResult)
        {
            return asyncResult.ToString();
        }
    }
}