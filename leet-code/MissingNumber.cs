public partial class Solution {
    public int MissingNumber(int[] nums)
    {
        var length = nums.Length;
        var expected = length * (length + 1) / 2;
        var actual = 0;
        for (int i = 0; i < length; i++)
        {
            actual += nums[i];
        }
        
        return expected - actual;
    }
}