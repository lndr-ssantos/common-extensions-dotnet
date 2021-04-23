using System;
using System.Linq;

namespace CommonExtensionsDotNet
{
    public static class DateTimeExtension
    {
        public static bool IsBusinessDay(this DateTime dateTime)
        {
            return !IsWeekend(dateTime);
        }

        public static bool IsWeekend(this DateTime dateTime)
        {
            return dateTime.DayOfWeek == DayOfWeek.Saturday || dateTime.DayOfWeek == DayOfWeek.Sunday;
        }
    }
}
