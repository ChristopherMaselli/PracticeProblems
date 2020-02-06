using System;
using System.Collections.Generic;

namespace PracticeProblems
{
    public class PascalsTriangle
    {
        /*
Given a non-negative integer numRows, generate the first numRows of Pascal's triangle.
Input: 5
Output:
[
     [1],
    [1,1],
   [1,2,1],
  [1,3,3,1],
 [1,4,6,4,1]
]
        */
        public string Solution()
        {
            int k = 5;
            List<List<int>> listOfLists = new List<List<int>>(k);
            string s = "";

            for (int i = 0; i < k; i++)
            {

                List<int> subList = new List<int>();
                subList.Add(1);
                if (i != 0)
                {
                    for (int j = 0; j < listOfLists[i - 1].Count - 1; j++)
                    {
                        subList.Add(listOfLists[i - 1][j] + listOfLists[i - 1][j + 1]);
                    }
                    subList.Add(1);
                }
                listOfLists.Add(subList);
            }









            for (int i = 0; i < (listOfLists.Count); i++)
            {
                for (int j = 0; j < (listOfLists[i].Count); j++)
                {
                    Console.Write(listOfLists[i][j]);
                }
                Console.WriteLine();
            }
            return s;
        }
    }
}