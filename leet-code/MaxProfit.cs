public partial class Solution {
    public int MaxProfit(int[] prices)
    {
        if (prices.Length == 0) return 0;
        var l = 0;
        var max = 0;

        for (var r = 0; r < prices.Length; r++)
        {
            if (prices[r] < prices[l]) l = r;
            max = Math.Max(max, prices[r] - prices[l]);
        }

        return max;
    }
}