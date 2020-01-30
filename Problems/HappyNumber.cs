using System;
using System.Collections.Generic;

namespace PracticeProblems {
    public class HappyNumber {
        /*
        Write an algorithm to determine if a number is "happy".

        A happy number is a number defined by the following process: 
        Starting with any positive integer, replace the number by the 
        sum of the squares of its digits, and repeat the process 
        until the number equals 1 (where it will stay), or it loops 
        endlessly in a cycle which does not include 1. Those numbers 
        for which this process ends in 1 are happy numbers.

        Input: 19
        Output: true
        Explanation: 
        12 + 92 = 82
        82 + 22 = 68
        62 + 82 = 100
        12 + 02 + 02 = 1

        */
        public string Solution () {

            int[] array2 = new int[] { 9, 4, 9, 8, 4 };

            //Put everything into HashSet
            HashSet<int> set = new HashSet<int> ();

            for (int i = 0; i < array2.Length; i++) {
                if (set.Contains (array2[i])) {
                    return "False";
                } else {
                    set.Add (array2[i]);
                }
            }

            return "True";

        }
    }
}