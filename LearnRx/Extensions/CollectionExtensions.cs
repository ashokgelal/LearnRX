using System;
using System.Collections.Generic;

namespace LearnRx.Extensions
{
    public static class CollectionExtensions
    {
        public static IEnumerable<TE> Map<T, TE>(this IEnumerable<T> coll, Func<T, TE> func)
        {
            foreach (var c in coll)
            {
                yield return func(c);
            }
        }
    }
}
