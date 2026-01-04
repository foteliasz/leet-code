public partial class Solution {
    public int MaxSubArray(int[] nums)
    {
        if (nums.Length == 0) return 0;
        if (nums.Length == 1) return nums[0];

        var current = nums[0];
        var max = nums[0];

        for (var i = 1; i < nums.Length; i++)
        {
            current = Math.Max(current + nums[i], nums[i]);
            max = Math.Max(current, max);
        }

        return max;
    }
}