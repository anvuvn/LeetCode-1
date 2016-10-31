using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class PermutationsIITest
    {
        [Theory]
        [MemberData("InlineData")]
        public void TestMethod(int[] nums, IList<IList<int>> output)
        {
            Assert.Equal(output, Solution047.PermuteUnique(nums));
        }

        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();
                int[] nums = new []{1,1,2};
                IList<IList<int>> output = new List<IList<int>>() {
                    new List<int> { 1,1,2 },
                    new List<int> { 1,2,1 },
                    new List<int> { 2,1,1 }
                };
                driverData.Add(new object[] { nums, output });
                
                return driverData;
            }
        }   
    }
}

