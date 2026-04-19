using Gedaq.Base.Model;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gedaq.Helpers
{
    internal static class CollectionHelper
    {
        public static bool SequnceEqual(
            this IEnumerable<MapTypeInfo> first,
            IEnumerable<MapTypeInfo> second,
            IEqualityComparer<ITypeSymbol> comparer,
            bool equalIfNull = false)
        {
            return
                (equalIfNull && first == null && second == null)
                || (first != null && second != null
                && first
                .Select(s =>s.MapType)
                .Where(wh => wh != null)
                .SequenceEqual(second
                    .Select(s => s.MapType)
                    .Where(wh => wh != null),
                    comparer));
        }
    }
}
