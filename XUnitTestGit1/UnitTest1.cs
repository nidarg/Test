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
            double expected = 5;
            double actual = Program.Add(3, 5);
            Assert.Equal(expected, actual);
        }
    }
}
