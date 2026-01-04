public partial class Solution {
    public int MaxAreaOfIsland(int[][] grid)
    {
        var max = 0;
        for (var r = 0; r < grid.Length; r++)
        {
            for (var c = 0; c < grid[r].Length; c++)
            {
                if (grid[r][c] == 0) continue;

                var curr = Explore(grid, r, c);
                if (curr > max) max = curr;
            }
        }

        return max;
    }

    private int Explore(int[][] grid, int r, int c)
    {
        if (r < 0 || r >= grid.Length) return 0;
        if (c < 0 || c >= grid[r].Length) return 0;
        if (grid[r][c] == 0) return 0;

        grid[r][c] = 0;
        var sum = 0;
        
        // N
        sum += Explore(grid, r - 1, c);
        // E
        sum += Explore(grid, r, c + 1);
        // S
        sum += Explore(grid, r + 1, c);
        // W
        sum += Explore(grid, r, c - 1);

        return sum + 1;
    }
}