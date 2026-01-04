public partial class Solution {
    public int NetworkDelayTime(int[][] times, int n, int k)
    {
        if (k == 0 || n == 0) return 0;
        
        var nodes = new ANode[n];

        #region Array init
        for (var i = 0; i < n; i++)
        {
            nodes[i] = new ANode { val = i + 1 };
        }
        #endregion

        #region Graph init
        foreach (var time in times)
        {
            var s = time[0];
            var d = time[1];
            var w = time[2];
            
            nodes[s - 1].edges
                .Add(new AEdge
                {
                    node = nodes[d - 1], 
                    weight = w
                });
        }
        #endregion
        
        var pq = new PriorityQueue<ANode, int>();
        pq.Enqueue(nodes[k - 1], 0);

        while (pq.Count > 0)
        {
            pq.TryDequeue(out var n1, out var w1);
            if (n1.shortest != -1) continue;

            n1.shortest = w1;

            foreach (var e1 in n1.edges)
            {
                if (e1.node.shortest != -1) continue;
                pq.Enqueue(e1.node, w1 + e1.weight);
            }
        }

        var res = 0;
        foreach (var n2 in nodes)
        {
            if (n2.shortest == -1) return -1;
            res = Math.Max(res, n2.shortest);
        }

        return res;
    }

    public class ANode
    {
        public int val;
        public List<AEdge> edges = new();
        public int shortest = -1;
    }

    public class AEdge
    {
        public int weight;
        public ANode node;
    }
}