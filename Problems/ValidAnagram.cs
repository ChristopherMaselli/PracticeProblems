using System;
using System.Collections.Generic;

namespace PracticeProblems {
    public class ValidAnagram {
        /*
        Given two strings s and t , write a function to determine if t is an anagram of s.
        
        Examples
        Input: s = "anagram", t = "nagaram"
        Output: true

        Input: s = "rat", t = "car"
        Output: false

        */
        public string Solution () {

            //APPARENTLY THE ANSWER IS JUST TO SORT THEM!!!!

            //My answer may actually be better apparently O_o;

            string s = "anagram";
            string t = "nagaram";

            string sol = "True";

            Dictionary<Char, int> dictS = new Dictionary<char, int> ();
            Dictionary<Char, int> dictT = new Dictionary<char, int> ();

            if (s.Length != t.Length) {
                return "False";
            }

            for (int i = 0; i < s.Length; i++) {
                if (dictS.ContainsKey (s[i])) {
                    dictS[s[i]] += 1;
                } else {
                    dictS.Add (s[i], 0);
                }
            }

            for (int i = 0; i < t.Length; i++) {
                if (dictT.ContainsKey (t[i])) {
                    dictT[t[i]] += 1;
                } else {
                    dictT.Add (t[i], 0);
                }
            }

            for (int i = 0; i < s.Length; i++) {
                if (dictS[s[i]] == dictT[s[i]]) {
                    continue;
                } else {
                    return "False";
                }
            }

            return "True";
        }
    }
}