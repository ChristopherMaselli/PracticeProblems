using System;
using System.Collections.Generic;

namespace PracticeProblems {
    public class HouseRobber {
        /*
        You are a professional robber planning to rob houses along a street. Each house has a certain amount 
        of money stashed, the only constraint stopping you from robbing each of them is that adjacent houses 
        have security system connected and it will automatically contact the police if two adjacent houses 
        were broken into on the same night.

        Given a list of non-negative integers representing the amount of money of each house, determine the 
        maximum amount of money you can rob tonight without alerting the police.

        Examples
        Input: [1,2,3,1]
        Output: 4

        Explanation: Rob house 1 (money = 1) and then rob house 3 (money = 3).
        Total amount you can rob = 1 + 3 = 4.

        Input: [2,7,9,3,1]
        Output: 12
        Explanation: Rob house 1 (money = 2), rob house 3 (money = 9) and rob house 5 (money = 1).
        Total amount you can rob = 2 + 9 + 1 = 12.
        */
        public string Solution () {
            //int[] array1 = new int[] { 1, 2, 2, 1 ,5};
            //int[] array2 = new int[] { 2, 2 };

            //int[] array1 = new int[] { 4, 9, 5 };
            int[] array1 = new int[] { 9, 4, 9, 8, 4 };

            int firstSum = 0;
            int secondSum = 0;

            for (int i = 0; i < array1.Length; i++) {
                if (i % 2 == 0) {
                    firstSum += array1[i];
                } else {
                    secondSum += array1[i];
                }
            }

            return Math.Max (firstSum, secondSum).ToString ();

        }
    }
}