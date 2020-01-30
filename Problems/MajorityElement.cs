using System;
using System.Collections.Generic;

namespace PracticeProblems {
    public class MajorityElement {
        /*
        Given an array of size n, find the majority element. The majority element is the element that appears more than ⌊ n/2 ⌋ times.
        You may assume that the array is non-empty and the majority element always exist in the array.

        Input: [3,2,3]
        Output: 3

        Input: [2,2,1,1,1,2,2]
        Output: 2
        */
        public string Solution () {
            //Actual solution is to just sort the array and then take the one at array.Length/2, this is
            //a dictionary-based solution
            int[] array2 = new int[] { 9, 4, 9, 8, 4, 9 };
            int majorityElement = 0;
            int majorityScore = 0;
            Dictionary<int, int> dict = new Dictionary<int, int> ();
            for (int i = 0; i < array2.Length; i++) {
                if (dict.ContainsKey (array2[i])) {
                    dict[array2[i]] += 1;
                } else {
                    dict.Add (array2[i], 0);
                }
            }

            for (int i = 0; i < array2.Length; i++) {
                {
                    if (majorityScore < dict[array2[i]]) {
                        majorityScore = dict[array2[i]];
                        majorityElement = array2[i];
                    }
                }
            }
            return majorityElement.ToString ();
        }
    }
}