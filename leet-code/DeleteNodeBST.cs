/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public partial class Solution {
    public TreeNode DeleteNode(TreeNode root, int key)
    {
        if (root is null) return root;
        if (key < root.val)
        {
            if (root.left is not null)
                root.left = DeleteNode(root.left, key);
            return root;
        }

        if (key > root.val)
        {
            if (root.right is not null)
                root.right = DeleteNode(root.right, key);
            return root;
        }

        if (root.val == key)
        {
            if (root.left is null)
            {
                return root.right;
            }

            if (root.right is null)
            {
                return root.left;
            }

            if (HasBothChildren(root))
            {
                var succ = GetMin(root.right);
                root.val = succ.val;
                succ.val = key;
                root.right = DeleteNode(root.right, key);
                return root;
            }
        }

        return root;
    }

    private bool HasBothChildren(TreeNode root)
    {
        return root.left is not null && root.right is not null;
    }

    private TreeNode GetMin(TreeNode root)
    {
        if (root is null) return null;
        var curr = root;
        while (curr.left is not null)
        {
            curr = curr.left;
        }

        return curr;
    }
    
}