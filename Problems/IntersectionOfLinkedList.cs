using System;
using System.Collections.Generic;

namespace PracticeProblems
{
    public class IntersectionOfLinkedList
    {
        /*
Write a program to find the node at which the intersection of two singly linked lists begins.

For example, the following two linked lists:

Input: intersectVal = 8, listA = [4,1,8,4,5], listB = [5,0,1,8,4,5], skipA = 2, skipB = 3
Output: Reference of the node with value = 8
Input Explanation: The intersected node's value is 8 (note that this must not be 0 if the two lists intersect). From the head of A, it reads as [4,1,8,4,5]. From the head of B, it reads as [5,0,1,8,4,5]. There are 2 nodes before the intersected node in A; There are 3 nodes before the intersected node in B.

        */
        public string Solution()
        {
            int[] array = new int[] { 4, 1, 8, 4, 5 };
            int[] array2 = new int[] { 5, 0, 1, 8, 4, 5 };

            //int[] array = new int[] { 0, 9, 1, 2, 4 };
            //int[] array2 = new int[] { 3, 2, 4 };

            //int[] array = new int[] { 2, 6, 4 };
            //int[] array2 = new int[] { 1, 5 };

            LinkedList<int> linkedList1 = new LinkedList<int>(array);
            LinkedList<int> linkedList2 = new LinkedList<int>(array2);
            bool comparisonBeginTrigger1 = false;
            bool comparisonBeginTrigger2 = false;

            LinkedListNode<int> pointerA = linkedList1.First;
            LinkedListNode<int> pointerB = linkedList2.First;

            while (true)
            {
                if (pointerA.Next == null && pointerB.Next == null)
                {
                    //return null;
                    return "null";
                }

                if (pointerA.Value == pointerB.Value && comparisonBeginTrigger1 == true && comparisonBeginTrigger2 == true)
                {
                    return pointerA.Value.ToString();
                }

                if (pointerA.Next == null)
                {
                    pointerA = linkedList2.First;
                    comparisonBeginTrigger1 = true;
                }
                else
                {
                    pointerA = pointerA.Next;
                }

                if (pointerB.Next == null)
                {
                    pointerB = linkedList1.First;
                    comparisonBeginTrigger2 = true;
                }
                else
                {
                    pointerB = pointerB.Next;
                }
            }



        }
    }
}