using System;
using System.Collections.Generic;

namespace PracticeProblems
{
    public class ReverseLinkedList
    {
        /*
Given a singly linked list, determine if it is a palindrome.

Example 1:

Input: 1->2
Output: false

Example 2:

Input: 1->2->2->1
Output: true

Follow up:
Could you do it in O(n) time and O(1) space?

Note: Built and used personal LinkedList class to do question without built-in functions
        */

        public class LinkedList
        {
            public LinkedList(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Append(array[i]);
                }
            }
            public class Node
            {
                // link to next Node in list
                public Node next;
                // value of this Node
                public object data;
            }
            public Node root = null;

            public Node First { get { return root; } }

            public Node Last
            {
                get
                {
                    Node curr = root;
                    if (curr == null)
                        return null;
                    while (curr.next != null)
                        curr = curr.next;
                    return curr;
                }
            }

            public void Append(object value)
            {
                Node n = new Node { data = value };
                if (root == null)
                    root = n;
                else
                    Last.next = n;
            }

            public void DeleteNode(Node node)
            {
                if (node.next != null)
                {
                    node.data = node.next.data;
                    node.next = node.next.next;
                }
                else
                {
                    node.data = null;
                }
            }
            public void printAllNodes()
            {
                Node current = First;
                while (current != null)
                {
                    Console.Write(current.data);
                    current = current.next;
                }
            }
            public Node selectNode(object value)
            {
                Node current = First;
                while (current != null)
                {
                    if ((int)current.data == (int)value)
                    {
                        return current;
                    }
                    current = current.next;
                }
                return current;
            }
            public LinkedList ReverseList(LinkedList linkedList)
            {
                Node prev = null;
                Node current = linkedList.First;
                while (current != null)
                {
                    Node nextTemp = current.next;
                    current.next = prev;
                    prev = current;
                    current = nextTemp;
                }
                return linkedList;
            }
        }


        public void Solution()
        {
            int[] array = new int[] { 4, 5, 1, 9 };
            LinkedList linkedList = new LinkedList(array);

            LinkedList.Node prev = null;
            LinkedList.Node current = linkedList.First;
            while (current != null)
            {
                LinkedList.Node nextTemp = current.next;
                current.next = prev;
                prev = current;
                current = nextTemp;
            }
            linkedList.root = prev;
            linkedList.printAllNodes();
        }
    }
}