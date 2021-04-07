using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace two_sum_in_array
{
    [TestClass]
    public class SolutionTest
    {
        [TestMethod]
        public void Example1()
        {
            var solution = new Solution();
            
            var nums = new int[]{2,7,11,15};
            var target = 9;
            var output = solution.TwoSum(nums, target);

            Console.WriteLine($"found: {output[0]}, {output[1]}");

            Assert.IsNotNull(output);
            Assert.AreEqual(target, nums[output[0]] + nums[output[1]]);
        }

        [TestMethod]
        public void Example2()
        {
            var solution = new Solution();
            
            var nums = new int[]{3,2,4};
            var target = 6;
            var output = solution.TwoSum(nums, target);

            Assert.IsNotNull(output);
            Assert.AreEqual(target, nums[output[0]] + nums[output[1]]);
        }

        [TestMethod]
        public void Example3()
        {
            var solution = new Solution();
            
            var nums = new int[]{3,3};
            var target = 6;
            var output = solution.TwoSum(nums, target);

            Assert.IsNotNull(output);
            Assert.AreEqual(target, nums[output[0]] + nums[output[1]]);
        }
    }
}
