public partial class Solution {
    public int MinEatingSpeed(int[] piles, int h)
    {
        var l = 1;
        var r = piles.Max();
        var res = r;
        while (l <= r)
        {
            var k = (l + r) / 2;
            long hours = 0;
            foreach (var pile in piles)
            {
                hours += (pile + k - 1) / k;
            }

            if (hours <= h)
            {
                res = k;
                r = k - 1;
            }
            else
            {
                l = k + 1;
            }
        }

        return res;
    }
}