public class Solution {
    public int MaxProfit(int[] prices) {
        int max = 0;
        int min = prices[0];

        for(int i = 1; i < prices.Length; i++){
            int profit = prices[i] - min;

            if(profit > max){
                max = profit;
            }
            if(prices[i] < min){
                min = prices[i];
            }

        }
        return max;
    }
}
