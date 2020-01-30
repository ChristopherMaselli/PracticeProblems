using System;
using System.Collections.Generic;

namespace PracticeProblems {
    public class MissingNumber {
        /*
        Given an array containing n distinct numbers taken from 0, 1, 2, ..., n, find the one that is missing from the array.
        
        Examples
        Input: [3,0,1]
        Output: 2

        Input: [9,6,4,2,3,5,7,0,1]
        Output: 8

        */
        public string Solution () {
            //int[] array = new int[] { 3, 0, 1 };
            int[] array = new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
            int count = 0;
            string s = "";

            Array.Sort (array);

            for (int i = 0; i < array.Length; i++) {
                if ((array[i] + 1) != array[i + 1]) {
                    return (array[i] + 1).ToString ();
                }
            }

            return "No Missing Number";

        }
    }
}