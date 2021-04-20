using System;
using CommonExtensionsDotNet;
using Xunit;

namespace CommonExtensionsDotnet.Tests
{
    public class ObjectExtensionTests
    {
        [Fact]
        public void ShouldValidIfObjectIsNull()
        {
            Object obj = null;

            Assert.True(obj.IsNull());
        }

        [Fact]
        public void ShouldValidIfObjectIsNotNull()
        {
            Object obj = new Object();

            Assert.True(obj.IsNotNull());
        }
    }
}
