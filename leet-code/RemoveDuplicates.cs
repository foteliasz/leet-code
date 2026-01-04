public partial class Solution {
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length <= 1) return nums.Length;
        
        var L = 1;
        int R;
        var current = nums[0];
        for (R = 1; R < nums.Length; R++)
        {
            if (nums[R] == current) continue;
            nums[L] = nums[R];
            current = nums[R];
            L++;
        }

        return L;
    }
}