using System;
using TestGit1;
using Xunit;

namespace XUnitTestGit1
{
    public class UnitTest1
    {
        [Fact]
        public void TestAddPass()
        {
            double expected = 8;
            double actual = Program.Add(3, 5);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestMultiplyPass()
        {
            double expected = 8;
            double actual = Program.Multiply(2, 4);
            Assert.Equal(expected, actual);
        }
    }
}
