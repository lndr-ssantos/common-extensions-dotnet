using System.Collections;

namespace CommonExtensionsDotNet
{
    public static class EnumerableExtension
    {
        public static bool IsNull(this IEnumerable enumerable)
        {
            return enumerable == null;
        }


        public static bool IsNullOrEmpty(this IEnumerable enumerable)
        {
            if (enumerable.IsNull()) return true;
            else if (enumerable.IsEmpty()) return true;

            return false;
        }
        
        private static bool IsEmpty(this IEnumerable enumerable)
        {
            return !enumerable.GetEnumerator().MoveNext();
        }
    }
}