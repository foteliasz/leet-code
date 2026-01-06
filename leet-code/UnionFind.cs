public class AUnionFind
{
    private readonly int _len;
    private readonly UNode[] _par;

    public AUnionFind(int[][] edges)
    {
        _len = edges.Length + 1;
        _par = new UNode[_len];

        for (var i = 1; i < _len; i++)
            _par[i] = new UNode();
    }

    public UNode Find(int n)
    {
        var curr = _par[n];
        while (curr.Par != curr)
        {
            curr.Par = curr.Par.Par;
            curr = curr.Par;
        }

        return curr;
    }

    public bool Union(int n1, int n2)
    {
        var p1 = Find(n1);
        var p2 = Find(n2);

        if (p1 == p2)
        {
            return false;
        }
            
        if (p1.Rank > p2.Rank)
        {
            p2.Par = p1;
            p1.Rank += p2.Rank;
        }
        else
        {
            p1.Par = p2;
            p2.Rank += p1.Rank;
        }

        return true;
    }
}

public class UNode
{
    public UNode Par { get; set; }
    public int Rank { get; set; }

    public UNode()
    {
        Par = this;
        Rank = 1;
    }
}