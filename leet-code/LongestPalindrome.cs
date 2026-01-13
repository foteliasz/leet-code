public partial class Solution {
    public string LongestPalindrome(string s)
    {
        var longest = "";

        for (var i = 0; i < s.Length; i++)
        {
            // Odd
            int l = i, r = i;
            while (l >= 0 && r < s.Length && s[l] == s[r])
            {
                var nLen = r - l + 1;
                if (nLen > longest.Length)
                    longest = s.Substring(l, nLen);

                r++;
                l--;
            }
            
            // Even
            l = i;
            r = i + 1;
            while (l >= 0 && r < s.Length && s[l] == s[r])
            {
                var nLen = r - l + 1;
                if (nLen > longest.Length)
                    longest = s.Substring(l, nLen);

                r++;
                l--;
            }
        }

        return longest;
    }
}