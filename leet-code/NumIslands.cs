public partial class Solution {
    public int NumIslands(char[][] grid)
    {
        var visited = new HashSet<(int r, int c)>();
        var res = 0;
        for (var r = 0; r < grid.Length; r++)
        {
            for (var c = 0; c < grid[r].Length; c++)
            {
                if (grid[r][c] != '1' || visited.Contains((r, c))) continue;
                
                Explore(grid, r, c, visited);
                res++;
            }
        }

        return res;
    }

    public void Explore(char[][] grid, int r, int c, HashSet<(int r, int c)> visited)
    {
        if (r < 0 || r >= grid.Length) return;
        if (c < 0 || c >= grid[r].Length) return;
        if (grid[r][c] == '0') return;
        if (visited.Contains((r, c))) return;

        visited.Add((r, c));

        // N
        Explore(grid, r - 1, c, visited);
        // E
        Explore(grid, r, c + 1, visited);
        // S
        Explore(grid, r + 1, c, visited);
        // W
        Explore(grid, r, c - 1, visited);
    }
}