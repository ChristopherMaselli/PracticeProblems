using System;
using System.Collections.Generic;

namespace PracticeProblems {
    public class ReverseAString {
        /*
Write a function that reverses a string. The input string is given as an array of characters char[].
Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.
You may assume all the characters consist of printable ascii characters.
    */
        public string Solution () {
            char[] array = new char[] { 'H', 'e', 'l', 'l', 'o' };
            string s = "";
            char placeholder;

            //Array.Reverse (array);

            for (int i = 0; i < (array.Length / 2); i++) {
                placeholder = array[array.Length - i - 1];
                array[array.Length - i - 1] = array[i];
                array[i] = placeholder;
            }
            for (int i = 0; i < (array.Length); i++) {
                s += array[i].ToString ();
            }
            return s;
        }
    }
}