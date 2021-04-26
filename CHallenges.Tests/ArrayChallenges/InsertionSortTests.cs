using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Challenges.ArrayChallenges;

namespace Challenges.Tests.ArrayChallenges
{
   public class InsertionSortTests
    {
        [Fact]
        public void InsertionSort_returns_an_array()
        {
            // arrange
            int[] arr = new int[6] { 8, 4, 23, 42, 16, 15 };


            // act
            int[] result = InsertionSort.InsertionSortFunc(arr);


            //assert
            Assert.Equal(arr, result);
        }


        [Fact]
        public void InsertionSort_returns_a_sorted_array()
        {
            // arrange
            int[] arr = new int[6] { 8, 4, 23, 42, 16, 15 };
            int[] sortedArr = new int[6] { 4, 8, 15, 16, 23, 42 };


            // act
            int[] result = InsertionSort.InsertionSortFunc(arr);


            //assert
            Assert.Equal(sortedArr, result);
        }

        [Fact]
        public void InsertionSort_works_with_array_with_multiple_same_numbers()
        {
            // arrange
            int[] arr = new int[12] { 8, 4, 23, 42, 16, 15, 4, 8, 15, -1, 12, 100 };
            int[] sortedArr = new int[12] { -1, 4, 4, 8, 8, 12, 15, 15, 16, 23, 42, 100 };


            // act
            int[] result = InsertionSort.InsertionSortFunc(arr);


            //assert
            Assert.Equal(sortedArr, result);
        }

    }
}
