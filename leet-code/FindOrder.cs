public partial class Solution {
    public int[] FindOrder(int numCourses, int[][] pre)
    {
        var cour = new BNode[numCourses];
        for (var i = 0; i < numCourses; i++)
            cour[i] = new BNode{ Val = i };

        foreach (var pair in pre)
        {
            var c = cour[pair[0]];
            var p = cour[pair[1]];
            c.Pre.Add(p);
        }

        var res = new List<int>();
        var path = new int[numCourses];

        foreach (var n in cour)
            if (!Traverse(n, path, res))
                return new int[0];

        return res.ToArray();
    }

    private bool Traverse(BNode n, int[] path, List<int> res)
    {
        if (path[n.Val] == 1) return false;
        if (path[n.Val] == 2) return true;

        path[n.Val] = 1;
        foreach (var p in n.Pre)
            if (!Traverse(p, path, res))
                return false;
        
        res.Add(n.Val);
        path[n.Val] = 2;

        return true;
    }

    private class BNode
    {
        public int Val { get; set; }
        public List<BNode> Pre { get; set; } = new();
    }
}