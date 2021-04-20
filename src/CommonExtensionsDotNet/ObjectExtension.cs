using System;

namespace CommonExtensionsDotNet
{
    public  static class ObjectExtension
    {
        public static bool IsNull(this Object obj)
        {
            return obj == null;
        }

        public static bool IsNotNull(this Object obj)
        {
            return obj != null;
        }
    }
}
