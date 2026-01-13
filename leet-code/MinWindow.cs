public partial class Solution {
    public string MinWindow(string s, string t)
    {
        Dictionary<char, int> need = new(), has = new();
        foreach (var c in t)
            if (!need.TryAdd(c, 1))
                need[c]++;

        int countH = 0, 
            countN = need.Count,
            resL = -1,
            resLen = int.MaxValue, 
            l = 0;

        for (var r = 0; r < s.Length; r++)
        {
            var rc = s[r];
            if (!has.TryAdd(rc, 1))
                has[rc]++;

            if (need.TryGetValue(rc, out var value) && value == has[rc])
                countH++;

            while (countH == countN)
            {
                if (r - l + 1 < resLen)
                {
                    resLen = r - l + 1;
                    resL = l;
                }

                var lc = s[l];
                has[lc]--;
                if (need.TryGetValue(lc, out var val) && has[lc] < val)
                    countH--;

                l++;
            }
        }
        
        return resLen == int.MaxValue 
            ? "" 
            : s.Substring(resL, resLen);
    }
}