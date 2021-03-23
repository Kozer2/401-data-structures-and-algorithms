using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges.Tests.ArrayChallenges
{
    class ArrayReverseTests
    {
        [Fact]
        public void Reverse_returns_empty_array_given_empty_array()
        {   
            // arrange
            int[] array = new int[0];

            // act
            ArrayReverse.Reverse(array);


            // assert
            Assert.Empty(result);

        }
    }
}
