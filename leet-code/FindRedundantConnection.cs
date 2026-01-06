public partial class Solution {
    public int[] FindRedundantConnection(int[][] edges)
    {
        var u = new AUnionFind(edges);
        var last = new int[0];
        foreach (var edge in edges)
        {
            var res = u.Union(edge[0], edge[1]);
            if (!res) last = edge;
        }

        return last;
    }
}