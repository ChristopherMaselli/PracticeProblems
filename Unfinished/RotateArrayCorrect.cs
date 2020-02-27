using System;
using System.Collections.Generic;

namespace PracticeProblems
{
    public class RotateArrayCorrect
    {
        /*
Given an array, rotate the array to the right by k steps, where k is non-negative.

Input: [1,2,3,4,5,6,7] and k = 3
Output: [5,6,7,1,2,3,4]
Explanation:
rotate 1 steps to the right: [7,1,2,3,4,5,6]
rotate 2 steps to the right: [6,7,1,2,3,4,5]
rotate 3 steps to the right: [5,6,7,1,2,3,4]
        */

        public string Solution()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int k = 3;
            int[] newArray = new int[array.Length];
            string s = "";
            if (array.Length < k)
            {
                k = k % array.Length;
            }
            int count = 0;
            for (int i = 0; count < array.Length; i++)
            {
                int current = i;
                int prev = array[i];
                do
                {
                    int next = (current + k) % array.Length;
                    int temp = array[next];
                    array[next] = prev;
                    prev = temp;
                    current = next;
                    count++;

                } while (i != current);
            }

            for (int i = 0; i < (array.Length); i++)
            {
                s += array[i].ToString();
            }
            return s;
        }
    }
}