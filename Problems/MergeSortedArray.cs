using System;
using System.Collections.Generic;

namespace PracticeProblems {
    public class MergeSortedArray {
        /*
        Given two sorted integer arrays nums1 and nums2, merge nums2 into nums1 as one sorted array. Remove Zero's as well
        */
        public string Solution () {
            int[] array1 = new int[] { 0, 0, 0, 1, 2, 3 };
            int[] array2 = new int[] { 2, 5, 6 };
            //List<int> list = new List<int>();
            int array3Length = array1.Length + array2.Length;
            List<int> array3 = new List<int> ();
            int countArray1 = 0;
            int countArray2 = 0;

            string s = "";

            for (int i = 0; i < (array3Length); i++) {
                if (countArray1 != array1.Length && countArray2 != array2.Length) {
                    if (array1[countArray1] <= array2[countArray2]) {
                        if (array1[countArray1] != 0) {
                            array3.Add (array1[countArray1]);
                        }

                        countArray1++;
                    } else {
                        if (array2[countArray2] != 0) {
                            array3.Add (array2[countArray2]);
                        }

                        countArray2++;
                    }
                } else if (countArray1 == array1.Length) {
                    if (array2[countArray2] != 0) {
                        array3.Add (array2[countArray2]);
                    }
                    countArray2++;
                } else if (countArray2 == array2.Length) {
                    if (array1[countArray1] != 0) {
                        array3.Add (array1[countArray1]);
                    }
                    countArray1++;
                }

            }

            for (int i = 0; i < (array3.Count); i++) {
                s += array3[i].ToString ();
            }

            return s;
        }
    }
}