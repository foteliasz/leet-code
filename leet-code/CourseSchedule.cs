public partial class Solution {
    
    // A.K.A. cycle detection
    public bool CanFinish(int numCourses, int[][] prerequisites)
    {
        var graph = new List<int>[numCourses];
        for (var i = 0; i < numCourses; i++)
            graph[i] = new List<int>();
        
        foreach (var prq in prerequisites)
            graph[prq[0]].Add(prq[1]);

        // 0 - unvisited
        // 1 - visiting
        // 2 - safe and visited
        var state = new int[numCourses];

        for (var i = 0; i < numCourses; i++)
        {
            if (state[i] != 0) continue;
            var res = Traverse(i, graph, state);
            if (!res) return false;
        }

        return true;
    }

    public bool Traverse(int c, List<int>[] graph, int[] state)
    {
        // Cycle detected
        if (state[c] == 1) return false;
        
        // Already checked
        if (state[c] == 2) return true;
        
        state[c] = 1;
        foreach (var pre in graph[c])
        {
            var res = Traverse(pre, graph, state);
            if (!res) return false;
        }

        state[c] = 2;
        return true;
    }
}