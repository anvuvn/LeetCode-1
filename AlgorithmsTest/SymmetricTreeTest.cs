using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class SymmetricTreeTest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(TreeNode root, bool output)
        {
            Assert.Equal(output, Solution101.IsSymmetric(root));
        }
    }
}

