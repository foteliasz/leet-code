public class NNode
{
    public int Key { get; set; }
    public int Val { get; set; }
    public NNode Next { get; set; }
    public NNode Prev { get; set; }  
}


public class LRUCache
{
    private int _cap;
    private Dictionary<int, NNode> _dict;
    private NNode _head;
    private NNode _tail;

    public LRUCache(int capacity)
    {
        _cap = capacity;
        _dict = new Dictionary<int, NNode>();
        _head = new NNode { Key = 0, Val = 0 };
        _tail = new NNode { Key = 0, Val = 0 };
        _head.Prev = _tail;
        _tail.Next = _head;
    }
    
    public int Get(int key) {
        if (!_dict.TryGetValue(key, out var nNode))
            return -1;
        
        Remove(nNode);
        Insert(nNode);
        return nNode.Val;
    }
    
    public void Put(int key, int value) {
        if (_dict.TryGetValue(key, out var nNode))
        {
            Remove(nNode);
            Insert(nNode);
            nNode.Val = value;
            return;
        }

        if (_dict.Count == _cap)
        {
            var toDel = _tail.Next;
            Remove(toDel);
            _dict.Remove(toDel.Key);
        }

        var toAdd = new NNode { Key = key, Val = value };
        Insert(toAdd);
        _dict[key] = toAdd;
    }

    private void Remove(NNode nNode)
    {
        if (ReferenceEquals(nNode, _tail.Next)) _tail.Next = nNode.Next;
        if (ReferenceEquals(nNode, _head.Prev)) _head.Prev = nNode.Prev;
        if (nNode.Next is not null) nNode.Next.Prev = nNode.Prev;
        if (nNode.Prev is not null) nNode.Prev.Next = nNode.Next;
    }

    private void Insert(NNode nNode)
    {
        nNode.Prev = _head.Prev;
        nNode.Next = _head;
        nNode.Prev.Next = nNode;
        _head.Prev = nNode;
    }
}