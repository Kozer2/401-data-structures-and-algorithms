using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.ArrayChallenges
{
    public class BinarySearch
    {
        public static int arrayBinarySearch(int[] arr, int num)
        {
            int minNum = 0;
            int maxNum = arr.Length - 1;
            

            while (minNum <= maxNum)
            {
                int midNum = (maxNum + minNum) / 2;
                if (arr[midNum] == num)
                {
                    return midNum;
                } // end if
                else if(arr[midNum] < num)
                {
                    minNum = midNum + 1;
                    
                }// end else if
                else if (arr[midNum] > num)
                {
                    maxNum = midNum - 1;

                } // end else if
                else
                {
                    maxNum = midNum - 1;
                } // end else


            } // end while

            return -1;
            
        } // end Binary Search Method
    }
}
