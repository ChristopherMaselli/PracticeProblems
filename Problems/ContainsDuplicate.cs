using System;
using System.Collections.Generic;

namespace PracticeProblems {
    public class ContainsDuplicate {
        /*
        Given an array of integers, find if the array contains any duplicates.
        Your function should return true if any value appears at least twice in the array, and it should return false if every element is distinct.
        
        Examples
        Input: [1,2,3,1]
        Output: true

        Input: [1,2,3,4]
        Output: false

        */
        public string Solution () {

            //APPARENTLY THE ANSWER IS TO JUST SORT THEM THEN SEARCH THROUGH FOR IF ONE IS EQUAL TO THE ONE AHEAD OF IT!!!!

            //UPDATE: My solution might actually be better O_o;

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