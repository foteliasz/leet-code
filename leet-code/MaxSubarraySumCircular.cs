public partial class Solution {
    public int MaxSubarraySumCircular(int[] nums)
    {
        int max = nums[0],
            min = nums[0],
            lMax = 0,
            lMin = 0,
            total = 0;
        
        foreach (var num in nums)
        {
            lMax = Math.Max(lMax + num, num);
            lMin = Math.Min(lMin + num, num);

            total += num;

            max = Math.Max(max, lMax);
            min = Math.Min(min, lMin);
        }

        return max < 0
            ? max
            : Math.Max(max, total - min);
    }
}