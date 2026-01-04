public partial class Solution {
    public int Rob(int[] nums)
    {
        if (nums.Length == 0) return 0;
        if (nums.Length == 1) return nums[0];
        
        var memo = new int[nums.Length];
        // for (var i = 0; i < memo.Length; i++)
        //     memo[i] = -1;
        
        // return RobTD(nums, 0, memo);
        // return RobBU(nums, memo);
        return RobBUO(nums);
    }

    private int RobTD(int[] nums, int pos, int[] memo)
    {
        if (pos >= nums.Length) return 0;
        if (memo[pos] != -1) return memo[pos];

        memo[pos] = Math.Max(
            nums[pos] + RobTD(nums, pos + 2, memo), 
            RobTD(nums, pos + 1, memo));

        return memo[pos];
    }

    private int RobBU(int[] nums, int[] memo)
    {
        memo[0] = nums[0];
        memo[1] = Math.Max(nums[0], nums[1]);
        
        for (var i = 2; i < nums.Length; i++)
        {
            memo[i] = Math.Max(nums[i] + memo[i - 2], memo[i - 1]);
        }

        return memo[nums.Length - 1];
    }
    
    private int RobBUO(int[] nums)
    {
        var curr = 0;
        var prev = 0;
        
        foreach (var num in nums)
        {
            var tmp = Math.Max(num + prev, curr);
            prev = curr;
            curr = tmp;
        }

        return curr;
    }
}