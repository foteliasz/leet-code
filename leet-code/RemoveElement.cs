public partial class Solution {
    public int RemoveElement(int[] nums, int val)
    {
        var L = 0;
        var R = 0;
        for (R = 0; R < nums.Length; R++)
        {
            if (nums[R] == val) continue;
            nums[L] = nums[R];
            L++;
        }

        return L;
    }
}