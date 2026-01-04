public partial class Solution {
    public int LengthOfLongestSubstring(string s)
    {
        var longest = 0;
        var left = 0;
        var buffer = new HashSet<char>();
        for (var right = 0; right < s.Length; right++)
        {
            if (buffer.Add(s[right]))
            {
                longest = Math.Max(longest, right - left + 1);
            }
            else
            {
                while (buffer.Contains(s[right]))
                {
                    buffer.Remove(s[left]);
                    left++;
                }
                buffer.Add(s[right]);
            }
        }

        return longest;
    }
}