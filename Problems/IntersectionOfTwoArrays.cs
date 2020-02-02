using System;
using System.Collections.Generic;

namespace PracticeProblems {
    public class IntersectionOfTwoArrays {
        /*
        Given two arrays, write a function to compute their intersection.
        */
        public string Solution () {
            //int[] array1 = new int[] { 1, 2, 2, 1 };
            //int[] array2 = new int[] { 2, 2 };

            int[] array1 = new int[] { 4, 9, 5 };
            int[] array2 = new int[] { 9, 4, 9, 8, 4 };

            HashSet<int> set1 = new HashSet<int> ();
            HashSet<int> set2 = new HashSet<int> ();

            List<int> solution = new List<int> ();
            string solutionS = "";

            for (int i = 0; i < array1.Length; i++) {
                set1.Add (array1[i]);
            }

            for (int i = 0; i < array2.Length; i++) {
                if (set1.Contains (array2[i]) && !set2.Contains (array2[i]) {
                        solution.Add (array2[i]);
                        set2.Add (array2[i]);
                    }
                }

                for (int i = 0; i < solution.Count; i++) {
                    solutionS += solution[i].ToString ();
                }

                return solutionS;

            }
        }
    }