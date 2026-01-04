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
    public IList<int> RightSideView(TreeNode root)
    {
        IList<int> res = new List<int>();
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        while (q.Count > 0)
        {
            var qLen = q.Count;
            TreeNode right = null;
            for (var i = 0; i < qLen; i++)
            {
                var n = q.Dequeue();
                if (n is null) 
                    continue;
                right = n;
                if (n.left is not null) 
                    q.Enqueue(n.left);
                if (n.right is not null) 
                    q.Enqueue(n.right);
            }
            if (right is not null) 
                res.Add(right.val);
        }

        return res ;
    }
}