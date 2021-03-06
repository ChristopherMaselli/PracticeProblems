using System;
using System.Collections.Generic;

namespace PracticeProblems
{
    public class TwoSum
    {
        /*
Given an array of integers, return indices of the two numbers such that they add up to a specific target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

Example:

Given nums = [2, 7, 11, 15], target = 9,

Because nums[0] + nums[1] = 2 + 7 = 9,
return [0, 1].

        */

        public string Solution()
        {
            int[] array = new int[] { 2, 7, 11, 15 };
            int target = 9;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            string s = "";

            for (int i = 0; i < (array.Length); i++)
            {
                dict.Add(target - array[i], i);
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (dict.ContainsKey(array[i]))
                {
                    s += i + " " + dict[array[i]];
                    return s;
                }
            }
            return s;
        }
    }
}
