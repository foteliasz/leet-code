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
    public List<int> InorderTraversal(TreeNode root)
    {
        var res = new List<int>();
        res = InorderTraversal(root, res);
        return res;
    }
    public List<int> InorderTraversal(TreeNode root, List<int> nodes)
    {
        if (root is null) return nodes;
        if (root.left is not null) InorderTraversal(root.left, nodes);
        nodes.Add(root.val);
        if (root.right is not null) InorderTraversal(root.right, nodes);
        return nodes;
    }
}