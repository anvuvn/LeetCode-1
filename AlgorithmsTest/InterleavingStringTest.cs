using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class InterleavingStringTest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(string s1, string s2, string s3, bool output)
        {
            Assert.Equal(output, Solution097.IsInterleave(s1, s2, s3));
        }
    }
}

