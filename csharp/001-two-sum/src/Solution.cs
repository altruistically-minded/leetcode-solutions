using System.Collections.Generic;

namespace two_sum_in_array
{
    public class Solution {
        public int[] TwoSum(int[] nums, int target) {

            // store the compliment and index
            var seen = new Dictionary<int, int>();

            for(int i = 0; i < nums.Length; i++){
                var compliment = target - nums[i];
                if(seen.TryGetValue(compliment, out int keyValue)){
                    return new int[] {i, keyValue};
                }
                seen.TryAdd(nums[i], i);
            }
            return null;
        }
    }
}