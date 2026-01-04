public class KthLargest
{
    private int _k;
    private PriorityQueue<int, int> _heap;

    public KthLargest(int k, int[] nums)
    {
        _k = k;
        _heap = new PriorityQueue<int, int>();
        foreach (var num in nums)
            _heap.Enqueue(num, num);
        while (_heap.Count > k)
            _heap.Dequeue();
    }
    
    public int Add(int val) {
        _heap.Enqueue(val, val);
        while (_heap.Count > _k)
            _heap.Dequeue();

        return _heap.Peek();
    }
}

