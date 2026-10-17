public class Solution {
    public int FindMin(int[] nums) {
        int len = nums.Length;
        int min = 1000;
        for(int i = 0; i < len; i++){
            min = Math.Min(nums[i], min);
                      
        }
        return min;
    }
}
