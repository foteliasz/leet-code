public partial class Solution
{
    public int[][] KClosest(int[][] points, int k)
    {
        var pq = new PriorityQueue<int[], long>();
        foreach (var point in points)
        {
            var x = point[0];
            var y = point[1];

            var len = (long)x * x + (long)y * y;
            pq.Enqueue(point, len);
        }

        var result = new int[k][];
        for (var i = 0; i < k; ++i)
        {
            var point = pq.Dequeue();
            result[i] = point;
        }

        return result;
    }
}

