public partial class Solution {
    public bool CanPartition(int[] nums)
    {
        var sum = 0;
        foreach (var num in nums)
            sum += num;

        // If odd, it is impossible
        if (sum % 2 != 0) return false;

        var target = sum / 2;
        var dp = new bool[target + 1];
        dp[0] = true;

        foreach (var num in nums)
        {
            for (var x = target; x >= num; x--)
            {
                // We check if we already were here
                // whatever iteration it was
                // OR we can be here,
                // by adding current number
                dp[x] = dp[x] || dp[x - num];
            }
        }

        return dp[target];
    }
    
}