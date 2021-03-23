using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges.ArrayChallenges
{
    public class ArrayShift
    {
        public static int[] insertShiftArray(int[] arr, int num)
        {
            int[] shiftArr = new int[arr.Length + 1]; // creates a new array that is one bigger as we need to add 1 number
            int numHolder = (shiftArr.Length / 2); // gets the mid point of the array
            for (int i = 0; i < shiftArr.Length; i++)
            {
                if(i < numHolder)
                {
                    shiftArr[i] = arr[i];
                }
                else if(i == numHolder)
                {
                    shiftArr[i] = num;
                }
                else
                {
                    shiftArr[i] = arr[i - 1];
                }
            }
            return shiftArr;
        }
    }
}
