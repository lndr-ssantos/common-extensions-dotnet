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
    }
}