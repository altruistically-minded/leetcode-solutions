using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace two_sum_in_array
{
    [TestClass]
    public class SolutionTest
    {
        [TestMethod]
        public void SingleDigit()
        {
            var solution = new Solution();
            
            var nums = new int[]{2,7,11,15};
            var target = 9;
            var output = solution.TwoSum(nums, target);

            Assert.IsNotNull(output);
            Assert.Equals(nums[output[0]] + nums[output[1]], target);
        }
    }
}
