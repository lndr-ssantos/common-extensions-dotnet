namespace CommonExtensionsDotNet
{
    public static class StringExtension
    {
        public static bool IsNull(this string sentence)
        {
            return sentence == null;
        }

        public static bool IsNotNull(this string sentence)
        {
            return sentence != null;
        }

        public static bool IsNullOrEmpty(this string sentence)
        {
            return string.IsNullOrEmpty(sentence);
        }
    }
}