public partial class Solution {
    public int LongestCommonSubsequence(string text1, string text2)
    {
        var grid = new int[text1.Length + 1, text2.Length + 1];

        for (var r = text1.Length - 1; r >= 0; r--)
        {
            for (var c = text2.Length - 1; c >= 0; c--)
            {
                if (text1[r] == text2[c])
                    grid[r, c] = 1 + grid[r + 1, c + 1];
                else
                    grid[r, c] = Math.Max(grid[r + 1, c], grid[r, c + 1]);
            }
        }

        return grid[0, 0];
    }
}