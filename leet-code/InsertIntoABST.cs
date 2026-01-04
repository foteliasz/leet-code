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
    public TreeNode InsertIntoBST(TreeNode root, int val)
    {
        if (root is null)
        {
            root = new TreeNode(val: val);
            return root;
        }
        
        var q = new Queue<TreeNode>();
        q.Enqueue(root);

        while (q.Count > 0)
        {
            var n = q.Dequeue();
            if (n.val == val) return root;
            if (val < n.val)
            {
                if (n.left is null)
                {
                    n.left = new TreeNode(val: val);
                    return root;
                }

                q.Enqueue(n.left);
            }

            if (val > n.val)
            {
                if (n.right is null)
                {
                    n.right = new TreeNode(val: val);
                    return root;
                }
                
                q.Enqueue(n.right);
            }
        }

        return root;
    }
}