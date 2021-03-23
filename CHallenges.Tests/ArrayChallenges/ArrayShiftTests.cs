using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Challenges.ArrayChallenges;

namespace Challenges.Tests.ArrayChallenges
{
    public class ArrayShiftTests
    {
        [Fact]
        public void insert_shift_array_even_size_returns_new_number_at_center()
        {
            // arrange
            int[] numArrTest = new int[4] { 2, 4, 6, 8 };
            int num = 5;

            // act
            int[] result = ArrayShift.insertShiftArray(numArrTest, num);

            //assert
            Assert.Equal(2, result[0]);
            Assert.Equal(4, result[1]);
            Assert.Equal(5, result[2]);
            Assert.Equal(6, result[3]);
            Assert.Equal(8, result[4]);
            
        }

        [Fact]
        public void insert_shift_array_odd_size_returns_new_number_at_center()
        {
            // arrange
            int[] numArrTest = new int[5] { 4, 8, 15, 23, 42 };
            int num = 16;

            // act
            int[] result = ArrayShift.insertShiftArray(numArrTest, num);

            //assert
            Assert.Equal(4, result[0]);
            Assert.Equal(8, result[1]);
            Assert.Equal(15, result[2]);
            Assert.Equal(16, result[3]);
            Assert.Equal(23, result[4]);
            Assert.Equal(42, result[5]);

        }
    }
}
