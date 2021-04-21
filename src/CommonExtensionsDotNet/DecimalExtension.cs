namespace CommonExtensionsDotNet
{
    public static class DecimalExtension
    {
        public static bool IsNegative(this decimal value)
        {
            return value < 0;
        }

        public static decimal RoundTo(this decimal value, int precision)
        {
            return decimal.Round(value, precision);
        }
    }
}