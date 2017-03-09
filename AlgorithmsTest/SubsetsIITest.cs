using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class SubsetsIITest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(int[] nums, IList<IList<int>> output)
        {
            Assert.Equal(output, Solution090.SubsetsWithDup(nums));
        }
    }
}

