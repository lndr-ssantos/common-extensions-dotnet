using System;
using CommonExtensionsDotNet;
using Xunit;

namespace CommonExtensionsDotnet.Tests
{
    public class ObjectExtensionTests
    {
        [Fact]
        public void ShouldValidateIfObjectIsNull()
        {
            Object obj = null;

            Assert.True(obj.IsNull());
        }

        [Fact]
        public void ShouldValidateIfObjectIsNotNull()
        {
            Object obj = new Object();

            Assert.True(obj.IsNotNull());
        }
    }
}
