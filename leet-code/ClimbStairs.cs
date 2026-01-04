public partial class Solution {
    public int ClimbStairs(int n)
    {
        var memo = new Dictionary<int, int>(); 
        // return ClimbTD(n, memo);
        // return ClimbBU(n, memo);
        return ClimbBUO(n);
    }

    private int ClimbTD(int n, Dictionary<int, int> memo)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        if (n == 2) return 2;
        if (memo.TryGetValue(n, out var climb)) return climb;

        memo[n] = ClimbTD(n - 1, memo) + ClimbTD(n - 2, memo);
        return memo[n];
    }

    private int ClimbBU(int n, Dictionary<int, int> memo)
    {
        memo[0] = 0;
        memo[1] = 1;
        memo[2] = 2;

        for (var i = 3; i <= n; i++)
        {
            memo[i] = memo[i - 1] + memo[i - 2];
        }

        return memo[n];
    }

    private int ClimbBUO(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        if (n == 2) return 2;

        var curr = 2;
        var prev = 1;

        for (var i = 3; i <= n; i++)
        {
            var temp = curr;
            curr = curr + prev;
            prev = temp;
        }

        return curr;
    }
}