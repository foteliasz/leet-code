public partial class Solution {
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int max = 0, curr = 0;
        foreach (var num in nums)
        {
            if (num == 0)
            {
                max = Math.Max(curr, max);
                curr = 0;
            }
            else
            {
                curr++;
            }
        }

        max = Math.Max(max, curr);
        return max;
    }
}