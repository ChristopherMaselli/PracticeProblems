using System;
using System.Collections.Generic;

namespace PracticeProblems
{
    public class BuySellStock
    {
        /*
        Say you have an array for which the ith element is the price of a given stock on day i.

        If you were only permitted to complete at most one transaction (i.e., buy one and sell one share of the stock), design an algorithm to find the maximum profit.

        Note that you cannot sell a stock before you buy one.

        Input: [7,1,5,3,6,4]
        Output: 5
        Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
        Not 7-1 = 6, as selling price needs to be larger than buying price.
        */
        public string Solution()
        {
            string s = "";
            /*
            int[] array = new int[] { 7, 1, 5, 3, 6, 4 };
            int[] sortedArray = new int[array.Length];
            int maxProfit = 0;
            int countUpper = array.Length - 1;
            int countLower = 0;

            string s = "";

            Dictionary<int, int> dict = new Dictionary<int, int> ();

            for (int i = 0; i < array.Length; i++) {
                dict.Add (array[i], i);
            }
            array.CopyTo (sortedArray, array.Length);
            Array.Sort (sortedArray);

            for (int i = 0; i < array.Length; i++) {
                if (dict (sortedArray[countLower]) < dict (sortedArray[countUpper])) {
                    if
                }
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