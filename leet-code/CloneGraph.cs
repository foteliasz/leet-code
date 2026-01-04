public partial class Solution
{
    public Node CloneGraph(Node node)
    {
        if (node is null) return null;
        var dict = new Dictionary<Node, Node>();
        return Copy(node, dict);
    }

    public Node Copy(Node n, Dictionary<Node, Node> dict)
    {
        if (dict.TryGetValue(n, out _))
            return dict[n];

        var cp = new Node(n.val);
        dict[n] = cp;

        foreach (var nbr in n.neighbors)
            cp.neighbors.Add(Copy(nbr, dict));
        
        return dict[n];
    }
}