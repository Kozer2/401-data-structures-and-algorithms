using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Challenges.ArrayChallenges;

namespace Challenges.Tests.ArrayChallenges
{
    public class ArrayReverseTests
    {
        [Fact]
        public void Reverse_returns_empty_array_given_empty_array()
        {   
            // arrange
            int[] array = new int[0];

            // act
            int[] result = ArrayReverse.Reverse(array);


            // assert
            Assert.Empty(result);

        }

        [Fact]
        public void Reverse_return_reversed_array_with_odd_count()
        {
            int[] array = new[] { 1, 2, 3, };

            int[] result = ArrayReverse.Reverse(array);

            Assert.Equal(3, result.Length);

            Assert.Equal(3, result[0]);
            Assert.Equal(2, result[1]);
            Assert.Equal(1, result[2]);

        }
    }
}
