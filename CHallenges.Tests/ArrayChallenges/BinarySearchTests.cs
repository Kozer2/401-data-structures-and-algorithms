using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Challenges.ArrayChallenges;

namespace Challenges.Tests.ArrayChallenges
{
    public class BinarySearchTests
    {
        [Fact]
        public void binary_array_even_size_passing()
        {
            // arrange
            int[] numArrTest = new int[6] { 4, 8, 15, 16, 23, 42 };
            int num = 15;

            // act
            int result = BinarySearch.arrayBinarySearch(numArrTest, num);

            //assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void binary_array_even_size_failing()
        {
            // arrange
            int[] numArrTest = new int[6] { 1, 2, 3, 5, 6, 7 };
            int num = 4;

            // act
            int result = BinarySearch.arrayBinarySearch(numArrTest, num);

            //assert
            Assert.Equal(-1, result);
        }

        [Fact]
        public void binary_array_odd_size_failing()
        {
            // arrange
            int[] numArrTest = new int[7] { 11, 22, 33, 44, 55, 66, 77 };
            int num = 90;

            // act
            int result = BinarySearch.arrayBinarySearch(numArrTest, num);

            //assert
            Assert.Equal(-1, result);
        }

        [Fact]
        public void binary_array_odd_size_passing()
        {
            // arrange
            int[] numArrTest = new int[7] { 11, 22, 33, 44, 55, 66, 77 };
            int num = 55;

            // act
            int result = BinarySearch.arrayBinarySearch(numArrTest, num);

            //assert
            Assert.Equal(4, result);
        }

        [Fact]
        public void binary_array_zero_size_array()
        {
            // arrange
            int[] numArrTest = new int[0];
            int num = 11;

            // act
            int result = BinarySearch.arrayBinarySearch(numArrTest, num);

            //assert
            Assert.Equal(-1, result);
        }
    }
}
