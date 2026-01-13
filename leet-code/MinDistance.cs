public partial class Solution {
    public int MinDistance(string wordA, string wordB)
    {
        // return CountTB(word1, word2, 0, 0);
        
        // var memo = new int?[wordA.Length, wordB.Length];
        // return CountTBO(wordA, wordB, 0, 0, memo);

        var dp = new int[wordA.Length + 1, wordB.Length + 1];
        for (var a = 0; a < wordA.Length + 1; a++)
            dp[a, wordB.Length] = wordA.Length - a;
        for (var b = 0; b < wordB.Length + 1; b++)
            dp[wordA.Length, b] = wordB.Length - b;
        
        for (var a = wordA.Length - 1; a >= 0; a--)
        for (var b = wordB.Length - 1; b >= 0; b--)
        {
            if (wordA[a] == wordB[b])
                dp[a, b] = dp[a + 1, b + 1];
            else
            {
                var val = Math.Min(
                    // Remove
                    dp[a + 1, b],
                    // Insert
                    dp[a, b + 1]);
                // Replace
                val = Math.Min(val, dp[a + 1, b + 1]);
                dp[a, b] = val + 1;
            }
        }

        return dp[0, 0];
    }

    private int CountTB(string wordA, string wordB, int offA, int offB)
    {
        // A is over, B is not over = so, we need to insert into word A
        if (offA == wordA.Length) return wordB.Length - offB;
        
        // A is not over, B is over = we have to truncate word A
        if (offB == wordB.Length) return wordA.Length - offA;
        
        // Chars are equal, nothing to do here
        // Lets move both pointer onwards
        if (wordA[offA] == wordB[offB])
            return CountTB(wordA, wordB, offA + 1, offB + 1);
        
        // Now, we have two distinct character we can do one of three:
        var res = Math.Min(
            
            // 1. Insert to A word. Now, both characters are equal,
            // offset B can be incremented looking for matching char
            CountTB(wordA, wordB, offA, offB + 1),
            
            // 2. Delete from word A. Thus, we need to move A pointer
            // one character onwards
            CountTB(wordA, wordB, offA + 1, offB));
        
        // 3. We replace char in A. Now, both are equal.
        // Nothing to do here. Both pointer can be incremented.
        res = Math.Min(res, CountTB(wordA, wordB, offA + 1, offB + 1));
        
        // We can return minimum + 1 (because of change made)
        return res + 1;
    }

    private int CountTBO(string wordA, string wordB, int offA, int offB, int?[,] memo)
    {
        if (offA == wordA.Length) return wordB.Length - offB;
        if (offB == wordB.Length) return wordA.Length - offA;
        if (memo[offA, offB].HasValue) return memo[offA, offB]!.Value;

        if (wordA[offA] == wordB[offB])
        {
            memo[offA, offB] = CountTBO(wordA, wordB, offA + 1, offB + 1, memo);
            return memo[offA, offB]!.Value;
        }
        
        var res = Math.Min(
            CountTBO(wordA, wordB, offA, offB + 1, memo),
            CountTBO(wordA, wordB, offA + 1, offB, memo));
        res = Math.Min(res, CountTBO(wordA, wordB, offA + 1, offB + 1, memo));
        
        memo[offA, offB] = res + 1;
        return memo[offA, offB]!.Value;
    }
}