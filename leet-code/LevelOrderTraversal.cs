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
    public List<List<int>> LevelOrder(TreeNode root)
    {
        var res = new List<List<int>>();
        var q = new Queue<TreeNode>();
        q.Enqueue(root);

        while (q.Count > 0)
        {
            var line = new List<int>();
            var qLen = q.Count;

            for (var i = 0; i < qLen; i++)
            {
                var n = q.Dequeue();
                if (n is not null)
                    line.Add(n.val);
                if (n.left is not null)
                    q.Enqueue(n.left);
                if (n.right is not null)
                {
                    q.Enqueue(n.right);
                }
            }
            res.Add(line);
        }

        return res;
    }
}