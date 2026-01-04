public partial class Solution {
    public int Search(int[] nums, int target)
    {
        var l = 0;
        var h = nums.Length - 1;
        while (l <= h)
        {
            var m = (l + h) / 2;
            if (nums[m] == target) return m;
            if (h - l == 0) return -1;
            if (target < nums[m])
            {
                h = m - 1;
            }

            if (target > nums[m])
            {
                l = m + 1;
            }
        }

        return -1;
    }
}