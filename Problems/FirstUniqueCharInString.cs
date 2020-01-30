using System;
using System.Collections.Generic;

namespace PracticeProblems {
    public class FirstUniqueCharInString {
        /*
        Given a string, find the first non-repeating character in it and return it's index. If it doesn't exist, return -1. 

        Examples:
        s = "leetcode"
        return 0.

        s = "loveleetcode",
        return 2.
        */
        public string Solution () {
            string s = "leetcode";
            //string s = "loveleetcode";
            //string s = "yoyo";

            //First, go through the string, as this is done put each char in a HashSet
            //Second, if a repeat is noticed, end the loop and print the char

            Dictionary<char, int> dict = new Dictionary<char, int> ();

            for (int i = 0; i < s.Length; i++) {
                if (dict.ContainsKey (s[i])) {
                    dict[s[i]] += 1;
                } else {
                    dict.Add (s[i], 0);
                }
            }

            for (int i = 0; i < s.Length; i++) {
                if (dict[s[i]] == 0) {
                    return i.ToString ();
                }
            }
            return "-1";
        }
    }
}