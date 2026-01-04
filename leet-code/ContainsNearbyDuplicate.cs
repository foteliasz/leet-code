public partial class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        if (nums.Length <= 1) return false;
        var hs = new HashSet<int>();
        var L = 0;
        hs.Add(nums[L]);

        for (var R = 1; R < nums.Length; R++)
        {
            if (Math.Abs(L - R) > k)
            {
                hs.Remove(nums[L]);
                L++;
            }

            if (!hs.Add(nums[R]))
            {
                return true;
            }
        }

        return false;
    }
}