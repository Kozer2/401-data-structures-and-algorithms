using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges.ArrayChallenges
{
    class ArrayReversed
    {
        public static int[] Reverse(int[] arr)
        {
            int[] newArr = new int[arr.Length];
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = arr[arr.Length - 1 - i];
                /*Console.Write(newArr[i]);*/
            }
            Console.WriteLine(String.Join(',', newArr));
            return newArr;
        }
    }
}
