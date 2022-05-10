using System;
using Xunit;
using Moq;

namespace App.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var util = new Util();

            var res = util.hello();

            Assert.Equal("hello", res);
        }
    }
}
