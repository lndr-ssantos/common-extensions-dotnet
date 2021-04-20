using System;
using CommonExtensionsDotNet;
using Xunit;

namespace CommonExtensionsDotnet.Tests
{
    public class StringExtensionTests
    {
        [Fact]
        public void ShouldValidateIfObjectIsNull()
        {
            string sentence = null;

            Assert.True(sentence.IsNull());
        }

        [Fact]
        public void ShouldValidateIfObjectIsNotNull()
        {
            string sentence = "";

            Assert.True(sentence.IsNotNull());
        }
    }
}
