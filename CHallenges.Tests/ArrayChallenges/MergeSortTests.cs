using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Challenges.ArrayChallenges;

namespace Challenges.Tests.ArrayChallenges
{
   public class MergeSortTests
    {
        [Fact]
        public void MergeSort_returns_an_array()
        {
            // arrange
            int[] arr = new int[6] { 8, 4, 23, 42, 16, 15 };


            // act
            int[] result = MergeSortChallenge.MergeSort(arr);


            //assert
            Assert.Equal(arr, result);
        }


        

    }
}
