public partial class Solution {
    public int LastStoneWeight(int[] stones)
    {
        var stack = new PriorityQueue<int, int>();
        foreach (var stone in stones)
        {
            stack.Enqueue(stone, -stone);
        }

        while (stack.Count > 1)
        {
            var x = stack.Dequeue();
            var y = stack.Dequeue();
            y = x - y;
            if (y > 0) stack.Enqueue(y, -y);
        }

        return stack.Count > 0 ? stack.Dequeue() : 0;
    }
}