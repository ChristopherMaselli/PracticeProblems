using System;
using System.Collections.Generic;

namespace PracticeProblems
{
    public class FizzBuzz
    {
        /*
Write a program that outputs the string representation of numbers from 1 to n.

But for multiples of three it should output “Fizz” instead of the number and for 
the multiples of five output “Buzz”. For numbers which are multiples of both three 
and five output “FizzBuzz”.
        */
        public string Solution()
        {

            //Make a list of numbers
            List<int> numbers = new List<int>();
            numbers.Add(4);
            numbers.Add(3);
            numbers.Add(2);
            numbers.Add(4);
            numbers.Add(5);
            numbers.Add(6);
            numbers.Add(100);
            numbers.Add(15);
            string solution = "";

            //Sort the list
            numbers.Sort();

            //For loop through the list and have it print and check the numbers.
            for (int i = 0; i < numbers.Count; i++)
            {

                if (numbers[i] % 3 == 0 && numbers[i] % 5 == 0)
                {
                    solution += "FizzBuzz," + Environment.NewLine;
                }
                else if (numbers[i] % 3 == 0)
                {
                    solution += "Fizz," + Environment.NewLine;
                }
                else if (numbers[i] % 5 == 0)
                {
                    solution += "Buzz," + Environment.NewLine;
                }
                else
                {
                    solution += numbers[i] + "," + Environment.NewLine;
                }
            }
            solution = solution.Substring(0, (solution.Length - 2));
            return solution;
        }
    }
}