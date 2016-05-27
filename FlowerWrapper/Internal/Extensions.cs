using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Threading.Tasks;
using Fiddler;

namespace FlowerWrapper.Internal
{
    internal static class Extensions
    {
        public static void SafeDispose(this IDisposable resource)
        {
            if (resource != null) resource.Dispose();
        }

        public static int? Get(this int[] array, int index)
        {
            return array.Length > index ? (int?)array[index] : null;
        }

        public static string Join(this IEnumerable<string> values, string separator)
        {
            return string.Join(separator, values);
        }

        public static Task WhenAll(this IEnumerable<Task> tasks)
        {
            return Task.WhenAll(tasks);
        }

        public static Task<T[]> WhenAll<T>(this IEnumerable<Task<T>> tasks)
        {
            return Task.WhenAll(tasks);
        }
    }
}
