﻿using Challenges.ArrayChallenges;
using System;

namespace Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            int []arrTest = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] arrTest2 = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 
                67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 
                173, 179, 181, 191, 193, 197, 199 };
            ArrayReverse.Reverse(arrTest);
            ArrayReverse.Reverse(arrTest2);
        }
    }
}
