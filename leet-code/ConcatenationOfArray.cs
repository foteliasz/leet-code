public partial class Solution {
    public int[] GetConcatenation(int[] nums)
    {
        var ans = new int[nums.Length * 2];
        for (var i = 0; i < nums.Length; i++)
        {
            ans[i] = nums[i];
            ans[i + nums.Length] = nums[i];
        }
        return ans;
    }
}