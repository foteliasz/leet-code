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
    public int KthSmallest(TreeNode root, int k)
    {
        var res = new List<int>();
        res = InorderTrav(root, res);
        return k - 1 > res.Count ? 0 : res[k - 1];
    }
    
    public List<int> InorderTrav(TreeNode root, List<int> nodes)
    {
        if (root is null) return nodes;
        if (root.left is not null) InorderTrav(root.left, nodes);
        nodes.Add(root.val);
        if (root.right is not null) InorderTrav(root.right, nodes);
        return nodes;
    }
}