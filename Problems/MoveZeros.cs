using System;
using System.Collections.Generic;

namespace PracticeProblems {
    public class MoveZeros {
        /*
        Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements.

        Input: [0,1,0,3,12]
        Output: [1,3,12,0,0]

        
        You must do this in-place without making a copy of the array.
        Minimize the total number of operations.
        */

        //Loop through the array
        //If see a zero, cut it out, make a counter
        //At end, add number of zeros of counter to the end of it.
        public string Solution () {
            int[] array = new int[] { 0, 1, 0, 3, 12 };
            int count = 0;
            string s = "";

            for (int i = 0; i < array.Length; i++) {
                if (array[i] == 0) {
                    array[i] = array[i + 1];
                    count++;
                }
            }

            for (int i = 0; i < count; i++) {
                array[array.Length - i - 1] = 0;
            }

            for (int i = 0; i < array.Length; i++) {
                s += array[i].ToString () + " ";

            }
            return s;
        }

    }
}