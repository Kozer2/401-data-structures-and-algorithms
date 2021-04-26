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
        public void InsertionSort_works()
        {
            // arrange
            int[] arr = new int[6] { 8, 4, 23, 42, 16, 15 };


            // act
            int[] result = InsertionSort.InsertionSortFunc(arr);


            //assert
            Assert.Equal(arr, result);
        }
    }
}
