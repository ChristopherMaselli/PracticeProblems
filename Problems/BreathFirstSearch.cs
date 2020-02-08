using System;
using System.Collections.Generic;

namespace PracticeProblems
{
    public class BreathFirstSearch
    {
        /*
Impliment Breath First Search Algorythm with Binary Tree
        */

        //Definition for a binary tree node.
        public class TreeNode
        {
            public string val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(string x) { val = x; }
        }

        public string Solution()
        {
            TreeNode head = new TreeNode("A");
            head.left = new TreeNode("B");
            head.right = new TreeNode("C");
            head.left.left = new TreeNode("D");
            head.left.right = new TreeNode("E");
            head.right.left = new TreeNode("F");
            head.right.right = new TreeNode("G");


            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(head);
            while (q.Count > 0)
            {
                head = q.Dequeue();
                Console.Write(head.val + " ");

                if (head.left != null)
                {
                    q.Enqueue(head.left);
                }
                if (head.right != null)
                {
                    q.Enqueue(head.right);
                }
            }
            return "";
        }
    }
}