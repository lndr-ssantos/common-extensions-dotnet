using CommonExtensionsDotNet;
using System;
using Xunit;

namespace CommonExtensionsDotnet.Tests
{
    public class DateTimeExtensionTests
    {
        [Fact]
        public void ShouldValidateAsBusinessDay()
        {
            var date = DateTime.Now;

            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                int daysUntilMonday = ((int)DayOfWeek.Monday - (int)date.DayOfWeek + 7) % 7;
                date.AddDays(daysUntilMonday);
            }

            var isBusinessDay = date.IsBusinessDay();

            Assert.True(isBusinessDay);
        }

        [Fact]
        public void ShouldValidateAsWeekend()
        {
            var today = DateTime.Today;
            int daysUntilSaturday = ((int)DayOfWeek.Saturday - (int)today.DayOfWeek + 7) % 7;
            var saturday = today.AddDays(daysUntilSaturday);

            var isWeekend = saturday.IsWeekend();

            Assert.True(isWeekend);
        }
    }
}
