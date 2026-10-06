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

public class Solution {
    public int DiameterOfBinaryTree(TreeNode root) {
        if (root == null)
        {
            return 0;
        }

        int maxDiameter = 0;
        GetHeight(root, ref maxDiameter);
        
        return maxDiameter;
    }

    public static int GetHeight(TreeNode root, ref int max)
    {
        if (root == null)
        {
            return 0;
        }

        int left = GetHeight(root.left, ref max);
        int right = GetHeight(root.right, ref max);

        int currentHeight = 1 + Math.Max(left, right);
        max = Math.Max(left+right, max);

        return currentHeight;
    }
}
