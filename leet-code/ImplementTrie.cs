
public class Trie
{
    public TNode Root { get; } = new TNode();
    
    public Trie() {
        
    }
    
    public void Insert(string word)
    {
        if (word.Length == 0) return;

        var curr = Root;
        foreach (var ch in word)
        {
            var index = ch - 'a';
            if (curr!.Nodes[index] == null)
                curr.Nodes[index] = new TNode();

            curr = curr.Nodes[index];
        }

        curr!.IsEnd = true;
    }
    
    public bool Search(string word)
    {
        var curr = Root;
        foreach (var ch in word)
        {
            var index = ch - 'a';
            if (curr!.Nodes[index] == null)
                return false;

            curr = curr.Nodes[index];
        }

        return curr!.IsEnd;
    }
    
    public bool StartsWith(string prefix) {
        var curr = Root;
        foreach (var ch in prefix)
        {
            var index = ch - 'a';
            if (curr!.Nodes[index] == null)
                return false;

            curr = curr.Nodes[index];
        }

        return curr!.IsEnd || curr.Nodes.Any();
    }

    public class TNode
    {
        public bool IsEnd { get; set; } = false;
        public TNode?[] Nodes { get; } = new TNode?[26];
    }
}