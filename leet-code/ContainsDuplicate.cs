public partial class Solution {
    public bool ContainsDuplicate(int[] nums)
    {
        var cache = new HashSet<int>();
        foreach (var num in nums)
        {
            if (!cache.Add(num))
            {
                return true;
            }
        }

        return false;
    }
}