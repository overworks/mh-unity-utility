using System;
using System.Collections.Generic;

namespace Mh
{
    public static partial class CollectionExtensions
    {
        public static bool IsNullOrEmpty<T>(this ICollection<T> collection)
        {
            return collection == null || collection.Count == 0;
        }
    }
}
