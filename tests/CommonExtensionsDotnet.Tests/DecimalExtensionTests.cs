using Xunit;
using CommonExtensionsDotNet;

namespace CommonExtensionsDotnet.Tests
{
    public class DecimalExtensionTests
    {
        [Fact]
        public void ShouldValidateIfNumberIsNegative()
        {
            var number = -1.1M;

            Assert.True(number.IsNegative());
        }

        [Fact]
        public void ShouldReturnNumberRounded()
        {
            var number = 1.1234m;
            var numberExpected = 1.12m;

            Assert.Equal(numberExpected, number.RoundTo(2));
        }
    }
}