using System;
using System.Collections.Generic;

namespace PracticeProblems
{
    public class DeleteNodeInLinkedList
    {
        /*
Write a function to delete a node (except the tail) in a singly linked list, given only access to that node.

Given linked list -- head = [4,5,1,9], which looks like following:

Input: head = [4,5,1,9], node = 5
Output: [4,1,9]
Explanation: You are given the second node with value 5, the linked list should become 4 -> 1 -> 9 after calling your function.

//Built and used personal LinkedList Class for practice vs using C# generic collections;
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
            private Node root = null;

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
        }





        public void Solution()
        {
            int[] array = new int[] { 4, 5, 1, 9 };
            LinkedList linkedList = new LinkedList(array);
            int number = 5;

            linkedList.DeleteNode(linkedList.selectNode(number));

            linkedList.printAllNodes();
        }
    }
}