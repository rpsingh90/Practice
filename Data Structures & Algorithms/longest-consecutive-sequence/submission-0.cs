public class Solution {
    public int LongestConsecutive(int[] nums) {
        var store = new HashSet<int>(nums);
        int result = 0;
        for (int i = 0 ; i < nums.Length; i++){
            int currVal = nums[i];
            if (!store.Contains(currVal - 1)) {
                int currLen = 0;
                while(store.Contains(currVal)){
                    currLen++;
                    currVal++;
                }
                result = Math.Max(result, currLen);
            }
        }
        return result;
    }
}