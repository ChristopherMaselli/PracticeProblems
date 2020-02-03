using System;
using System.Collections.Generic;

namespace PracticeProblems {
    public class RotateArray {
        /*
Given an array, rotate the array to the right by k steps, where k is non-negative.

Input: [1,2,3,4,5,6,7] and k = 3
Output: [5,6,7,1,2,3,4]
Explanation:
rotate 1 steps to the right: [7,1,2,3,4,5,6]
rotate 2 steps to the right: [6,7,1,2,3,4,5]
rotate 3 steps to the right: [5,6,7,1,2,3,4]
        */

        public string Solution () {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int k = 3;
            string s = "";
            int r;
            int d;

            if (array.Length => k) {
                r = array.Length % k;
                d = array.Length / k
            } else {
                r = k % array.Length;
            }

            for (int i = 0; i < array.Length; i++) {

            }

            /*
            for (int i = 0; i < (array.Length); i++) {
                s += array[i].ToString ();
            }
            return s;
            */
            return s;
        }
    }
}