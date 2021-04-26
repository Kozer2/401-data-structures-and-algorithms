using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.ArrayChallenges
{
   public class InsertionSort
    {
        public static int[] InsertionSortFunc(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int valueKey = arr[i];
                int j = i - 1;

                while(j >= 0 && arr[j] > valueKey)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                    arr[j + 1] = valueKey;
                }

            }
            return arr;
        }
    }
}
