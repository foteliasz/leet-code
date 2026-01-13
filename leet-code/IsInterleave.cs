public partial class Solution {
    public bool IsInterleave(string sA, string sB, string sC)
    {
        if (sA.Length + sB.Length != sC.Length) return false;

        var memo = new bool?[sA.Length + 1, sB.Length + 1];
        return IsInterleave(0, 0, sA, sB, sC, memo);
    }

    private bool IsInterleave(int a, int b, string sA, string sB, string sC, bool?[,] memo)
    {
        if (a == sA.Length && b == sB.Length) return true;
        if (memo[a, b].HasValue) return memo[a, b]!.Value;

        if (a < sA.Length && 
            sA[a] == sC[a + b] && 
            IsInterleave(a + 1, b, sA, sB, sC, memo))
        {
            return true;
        }

        if (b < sB.Length &&
            sB[b] == sC[a + b] &&
            IsInterleave(a, b + 1, sA, sB, sC, memo))
        {
            return true;
        }

        memo[a, b] = false;
        return false;
    }
}