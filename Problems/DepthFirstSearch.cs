using System;
using System.Collections.Generic;

namespace PracticeProblems
{
    public class DepthFirstSearch
    {
        /*
Impliment Depth First Search Algorythm with Binary Tree
        */

        //Definition for a binary tree node.
        public class TreeNode
        {
            public string val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(string x) { val = x; }
        }

        static void dfs_traversal(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            Console.Write(node.val + " ");
            dfs_traversal(node.left);
            dfs_traversal(node.right);
        }

        public string Solution()
        {
            TreeNode head = new TreeNode("A");
            head.left = new TreeNode("B");
            head.right = new TreeNode("E");
            head.left.left = new TreeNode("C");
            head.left.right = new TreeNode("D");
            head.right.left = new TreeNode("F");
            head.right.right = new TreeNode("G");

            dfs_traversal(head);

            return "";

        }
    }
}