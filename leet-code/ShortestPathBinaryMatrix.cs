public partial class Solution
{
    private Pos[] dirs8 = new[]
    {
        // N
        new Pos { r = -1, c = 0 },
        // NE
        new Pos { r = -1, c = 1 },
        // E
        new Pos { r = 0, c = 1 },
        // SE
        new Pos { r = 1, c = 1 },
        // S
        new Pos { r = 1, c = 0 },
        // SW
        new Pos { r = 1, c = -1 },
        // W
        new Pos { r = 0, c = -1 },
        // NW
        new Pos { r = -1, c = -1 }
    };
    
    public int ShortestPathBinaryMatrix(int[][] grid)
    {
        var q = new Queue<Pos>();
        var s = new Pos { r = 0, c = 0 };
        var d = new Pos { r = grid.Length - 1, c = grid[s.r].Length - 1 };
        
        if (grid[s.r][s.c] == 1 || grid[d.r][d.c] == 1) return -1;
        
        q.Enqueue(s);
        grid[s.r][s.c] = 1;
        var len = 1;

        while (q.Count > 0)
        {
            var qLen = q.Count;
            for (var _ = 0; _ < qLen; _++)
            {
                var pos = q.Dequeue();
                if (pos == d) return len;
                
                foreach (var dir in dirs8)
                {
                    var nPos = new Pos { r = pos.r + dir.r, c = pos.c + dir.c };
                    
                    if (nPos.r < 0 || nPos.r >= grid.Length) continue;
                    if (nPos.c < 0 || nPos.c >= grid[nPos.r].Length) continue;
                    if (grid[nPos.r][nPos.c] == 1) continue;
                    
                    q.Enqueue(nPos);
                    grid[nPos.r][nPos.c] = 1;
                }
            }

            len++;
        }
        
        return -1;
    }
}