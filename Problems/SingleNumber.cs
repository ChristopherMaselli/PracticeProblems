using System;
using System.Collections.Generic;

namespace PracticeProblems
{
    public class SingleNumber
    {
        /*
Given a non-empty array of integers, every element appears twice except for one. Find that single one.

Note:

Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory?

Example 1:

Input: [2,2,1]
Output: 1

Example 2:

Input: [4,1,2,1,2]
Output: 4
        */
        public string Solution()
        {
            int[] array = new int[] { 4, 1, 2, 1, 2 };
            string s = "";

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (dict.ContainsKey(array[i]))
                {
                    dict[array[i]] += 1;
                }
                else
                {
                    dict.Add(array[i], 0);
                }
            }

            foreach (var keyValuePair in dict)
            {
                if (keyValuePair.Value == 0)
                {
                    s = keyValuePair.Key.ToString();
                }
            }

            return s;
        }
    }
}