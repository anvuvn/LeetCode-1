using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class SameTreeTest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(TreeNode p, TreeNode q, bool output)
        {
            Assert.Equal(output, Solution100.IsSameTree(p, q));
        }
    }
}

