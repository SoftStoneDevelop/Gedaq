using Gedaq.DbConnection.GeneratorsQuery;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gedaq.Helpers
{
    internal static class CollectionHelper
    {
        public static bool SequnceEqual<TSource>(
            this IEnumerable<TSource> first,
            IEnumerable<TSource> second,
            IEqualityComparer<TSource> comparer,
            bool equalIfNull = false)
        {
            return
                (equalIfNull && first == null && second == null)
                || (first != null && second != null && first.SequenceEqual(second, comparer));
        }
    }
}
