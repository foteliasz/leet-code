public partial class Solution
{
    public int UniquePaths(int m, int n)
    {
        if (m == 0 || n == 0) return 0;
        if (m == 1 || n == 1) return 1;
        
        var grid = new int[m, n];
        for (var r = 0; r < m; r++)
            grid[r, n - 1] = 1;
        for (var c = 0; c < n; c++)
            grid[m - 1, c] = 1;

        for (var r = m - 2; r >= 0; r--)
        {
            for (var c = n - 2; c >= 0; c--)
            {
                grid[r, c] = grid[r + 1, c] + grid[r, c + 1];
            }
        }

        return grid[0, 0];
    }

}