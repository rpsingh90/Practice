public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
     var result = new Dictionary<int, int>();
     var resultList = new List<int>();
     for(int i = 0 ; i < nums.Length; i++){
        if(result.ContainsKey(nums[i])){
            result[nums[i]]++;
        }
        else{
            result[nums[i]] = 1;
        }
     }
     var descending = result.OrderByDescending(pair => pair.Value);   

     foreach(var pair in descending){
         if (k == 0) {
        break;
    }

    resultList.Add(pair.Key);
    k--;
     }
    return resultList.ToArray();
    }
}
