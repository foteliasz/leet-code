public partial class Solution {
    public void SortColors(int[] nums)
    {
        var colors = new int[] {0 ,0 ,0};
        foreach (var num in nums)
        {
            colors[num]++;
        }

        var p = 0;
        for (var outer = 0; outer < colors.Length; outer++)
        {
            for (var inner = 0; inner < colors[outer]; inner++)
            {
                nums[p] = outer;
                p++;
            }
        }
    }
}