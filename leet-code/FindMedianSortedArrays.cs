public partial class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        var lenght = nums1.Length + nums2.Length;
        var nums3 = nums1.Concat(nums2).Order();

        var middle = lenght / 2;
        if (lenght % 2 == 1)
            return nums3.ElementAt(middle);

        var one = nums3.ElementAt(middle);
        var two = nums3.ElementAt(middle - 1);
        return (one + two) / 2d;
    }
}
