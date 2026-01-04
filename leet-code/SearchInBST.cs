

public partial class Solution {
    public TreeNode SearchBST(TreeNode root, int val)
    {
        var current = root;
        while (true)
        {
            if (val < current.val)
            {
                if (current.left is null)
                {
                    return null;
                }
                current = current.left;
            }

            if (val > current.val)
            {
                if (current.right is null)
                {
                    return null;
                }
                current = current.right;
            }

            if (val == current.val)
            {
                return current;
            }
        }
    }
}