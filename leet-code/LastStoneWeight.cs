public partial class Solution {
    public int LastStoneWeight(int[] stones)
    {
        var heap = new PriorityQueue<int, int>();
        foreach (var stone in stones)
        {
            heap.Enqueue(stone, -stone);
        }

        while (heap.Count > 1)
        {
            var x = heap.Dequeue();
            var y = heap.Dequeue();
            y = x - y;
            if (y > 0) heap.Enqueue(y, -y);
        }

        return heap.Count > 0 ? heap.Dequeue() : 0;
    }
}