using System;
using System.Collections.Generic;

namespace PracticeProblems {
    public class PowerOfThree {
        //Given an integer, write a function to determine if it is a power of three.
        public string Solution (int number) {
            if (number % 3 == 0) {
                number = number / 3;
                if (number % 3 == 0) {
                    number = number / 3;
                    if (number % 3 == 0) {
                        return 1. ToString ();
                    }
                }
            }
            return 0. ToString ();
        }
    }
}