public partial class Solution
{
    private Pos[] dirs4 = new[]
    {
        // N
        new Pos { r = -1, c = 0 },
        // E
        new Pos { r = 0, c = 1 },
        // S
        new Pos { r = 1, c = 0 },
        // W
        new Pos { r = 0, c = -1 },
    };
    
    public int OrangesRotting(int[][] grid)
    {
        var q = new Queue<Pos>();

        for (var r = 0; r < grid.Length; r++)
        {
            for (var c = 0; c < grid[r].Length; c++)
            {
                if (grid[r][c] == 2) 
                    q.Enqueue(new Pos { r = r, c = c});
            }
        }
        
        var t = 0;
        while (q.Count > 0)
        {
            var qLen = q.Count;
            for (var _ = 0; _ < qLen; _++)
            {
                var p = q.Dequeue();

                foreach (var dir in dirs4)
                {
                    var pos = new Pos { r = p.r + dir.r, c = p.c + dir.c };
                    
                    if (pos.r < 0 || pos.r >= grid.Length) continue;
                    if (pos.c < 0 || pos.c >= grid[pos.r].Length) continue;
                    if (grid [pos.r][pos.c] != 1) continue;
                    
                    q.Enqueue(pos);
                    grid[pos.r][pos.c] = 2;
                }
            }
            if (q.Count > 0) t++;
        }
        
        for (var r = 0; r < grid.Length; r++)
        {
            for (var c = 0; c < grid[r].Length; c++)
            {
                if (grid[r][c] == 1)
                    return -1;
            }
        }

        return t;
    }
}
