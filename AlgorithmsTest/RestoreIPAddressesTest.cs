using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class RestoreIPAddressesTest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(string s, IList<string> output)
        {
            Assert.Equal(output, Solution093.RestoreIpAddresses(s));
        }
    }
}

