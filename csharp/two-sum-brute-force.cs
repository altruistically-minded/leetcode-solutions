public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int truck = 1;
        int trailer = 0;
        
        // Array.Sort(nums);
        
        for(trailer = 0; trailer < nums.Length-1; trailer++)
        {
            var results = -1;
            for(truck = trailer + 1; truck < nums.Length; truck++)
            {
                results = nums[trailer] + nums[truck];
            
                if(results == target  /*|| results > target*/){
                    break;
                } 
            }
            
            if(results == target){
                break;
            } 
        }
        
        return new int[] {trailer, truck}; 
    }
}
