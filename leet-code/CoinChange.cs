public partial class Solution {
    public int CoinChange(int[] coins, int amount)
    {
        var cache = new int[amount + 1];
        for (var i = 1; i < cache.Length; i++)
            cache[i] = amount + 1;
        cache[0] = 0;

        for (var a = 0; a < cache.Length; a++)
            foreach (var c in coins)
            {
                if (a - c < 0) continue;
                cache[a] = Math.Min(cache[a], cache[a - c] + 1);
            }

        return cache[amount] != amount + 1
            ? cache[amount]
            : -1;
    }
}