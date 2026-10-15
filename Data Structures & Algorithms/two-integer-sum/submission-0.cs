public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var result = new int[2];
        var mapr = new Dictionary<int, int>();
        int count = 0;
        for(int i = 0; i < nums.Length; i++){
            count = target - nums[i];
            if(mapr.ContainsKey(count)){
                result[0] = mapr[count];
                result[1] = i;
                return result;
            }
            else{
                mapr[nums[i]] = i;
            }
        }
    return result;
    }
}
