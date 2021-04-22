using System.Collections.Generic;
using CommonExtensionsDotNet;
using Xunit;

namespace CommonExtensionsDotnet.Tests
{
    public class EnumerableExtensionTests
    {
        [Fact]
        public void ShouldValidateIfListIsNull()
        {
            var list = new int[] { 1, 2, 3};

            Assert.False(list.IsNull());
        }

        [Fact]
        public void ShouldValidateIfListIsNullOrEmpty()
        {
            var list = new List<int>();

            Assert.True(list.IsNullOrEmpty());
        }
    }
}