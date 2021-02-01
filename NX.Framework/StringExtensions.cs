using System.Collections.Generic;
using System.Linq;

namespace NX.Framework
{
    public static class StringExtensions
    {
        public static string AsNullIfEmpty(this string items) => string.IsNullOrEmpty(items) ? null : items;
        public static string AsNullIfWhiteSpace(this string items) => string.IsNullOrWhiteSpace(items) ? null : items;
        public static IEnumerable<T> AsNullIfEmpty<T>(this IEnumerable<T> items)
        {
            IEnumerable<T> asNullIfEmpty = items as T[] ?? items.ToArray();
            return !asNullIfEmpty.Any() ? null : asNullIfEmpty;
        }
    }
}
