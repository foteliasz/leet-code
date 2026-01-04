public partial class Solution {
    public int MinCostConnectPoints(int[][] points)
    {
        // Where (int, int) represents (destination, weight)
        var graph = new List<(int dst, int w)>?[points.Length];
        for (var a = 0; a < points.Length; a++)
        {
            graph[a] ??= new List<(int, int)>();
            
            var x1 = points[a][0];
            var y1 = points[a][1];
            for (var b = a + 1; b < points.Length; b++)
            {
                graph[b] ??= new List<(int, int)>();
                
                var x2 = points[b][0];
                var y2 = points[b][1];
                var w = Math.Abs(x1 - x2) + Math.Abs(y1 - y2);
                
                graph[a]!.Add((b, w));
                graph[b]!.Add((a, w));
            }
        }
        
        // Where (int, int, int) represents (destination, weight)
        var heap = new PriorityQueue<(int, int), int>();
        var visit = new HashSet<int>();
        visit.Add(0);
        foreach (var (dst, w) in graph[0]!)
            heap.Enqueue((dst, w), w);

        var res = 0;
        
        while (visit.Count < points.Length)
        {
            var (dst1, w1) = heap.Dequeue();
            // If already exists skip
            if (!visit.Add(dst1)) continue;

            res += w1;

            foreach (var (dst2, w2) in graph[dst1]!)
            {
                if (visit.Contains(dst2)) continue;
                heap.Enqueue((dst2, w2), w2);
            }
        }

        return res;
    }
}