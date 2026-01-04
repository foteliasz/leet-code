public partial class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        // Will store pair of <value, index>
        var dict = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            // What is other missing value
            var other = target - nums[i];
            
            // Check if missing value is already there
            if (dict.TryGetValue(other, out var value))
                // Return current index + index sorted in dict
                return new[] { value, i };
            
            // Otherwise extend dict with new <value, index> pair
            dict[nums[i]] = i;
        }

        return new int[0];
    }
}