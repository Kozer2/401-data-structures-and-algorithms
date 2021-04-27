using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.ArrayChallenges
{
   public class MergeSortChallenge
    {
        public static int[] MergeSort(int[] arr)
        {
            int n = arr.Length;

            
            if(n > 1)
            {
                int mid = arr.Length / 2;
                int[] left = new int[mid];
                int[] right = new int[mid];
                for (int i = 0; i < mid; i++)
                {
                    left[i] = arr[i];
                }
                int x = 0;
                for (int i = mid; i < arr.Length; i++)
                {
                    right[x] = arr[i];
                    x++;
                }

                MergeSort(left);
                MergeSort(right);
                Merge(left, right, arr);
            }

            return arr;        
        }

        public static int[] Merge(int[] left, int[] right, int[] arr) 
        {
            int i = 0;
            int j = 0;
            int k = 0;

            while (i < left.Length && j < right.Length)
               {
                if (left[i] <= right[j])
                {
                    arr[k] = right[j];
                    j =+ 1;
                }
                k += 1;

               }
            if (i == left.Length)
            {
                arr[k] = right[j];
            }
            else
                arr[k] = left[i];

            return arr;
        }

    }
}
