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
        if (!_dict.TryGetValue(key, out var NNode))
            return -1;
        
        Remove(NNode);
        Insert(NNode);
        return NNode.Val;
    }
    
    public void Put(int key, int value) {
        if (_dict.TryGetValue(key, out var NNode))
        {
            Remove(NNode);
            Insert(NNode);
            NNode.Val = value;
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

    private void Remove(NNode NNode)
    {
        if (ReferenceEquals(NNode, _tail.Next)) _tail.Next = NNode.Next;
        if (ReferenceEquals(NNode, _head.Prev)) _head.Prev = NNode.Prev;
        if (NNode.Next is not null) NNode.Next.Prev = NNode.Prev;
        if (NNode.Prev is not null) NNode.Prev.Next = NNode.Next;
    }

    private void Insert(NNode NNode)
    {
        NNode.Prev = _head.Prev;
        NNode.Next = _head;
        NNode.Prev.Next = NNode;
        _head.Prev = NNode;
    }
}