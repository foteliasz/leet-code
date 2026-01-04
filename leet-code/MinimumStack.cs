public class MinStack
{
    private Stack<int> _stack = new();
    private Stack<int> _mins = new();
    private int _min = int.MaxValue;
    public MinStack()
    {
    }

    private void _reset()
    {
        _min = int.MaxValue;
    }
    
    public void Push(int val)
    {
        if (val <= _min)
        {
            _min = val;
            _mins.Push(val);
        }
        _stack.Push(val);
    }
    
    public void Pop()
    {
        var curr = _stack.Pop();
        if (_mins.Count == 0)
        {
            _reset();
            return;
        };
        if (curr != _mins.Peek()) return;
        _mins.Pop();
        if (_mins.Count == 0)
        {
            _reset();
            return;
        }
        _min = _mins.Peek();
    }
    
    public int Top()
    {
        return _stack.Peek();
    }
    
    public int GetMin()
    {
        return _min;
    }
}