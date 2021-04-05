using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Challenges.PseudoQueueChallenges;

namespace Challenges.Tests.PseudeoQueueTests
{
   public class PseudoQueueTests
    {
        [Fact]
        public void Enqueue_and_IsEmpty_work()
        {
            // arrange
            PseudoQueue<int> queue = new PseudoQueue<int>();
             // assert
            Assert.True(queue.IsEmpty);
            // act
            queue.Enqueue(1);

            // assert
            Assert.False(queue.IsEmpty);
        }

        [Fact]
        public void Dequeue_works()
        {
            // arrange
            PseudoQueue<int> queue = new PseudoQueue<int>();
            queue.Enqueue(1);

            // act
            queue.Enqueue(2);
            int result = queue.Dequeue();

            // assert
            Assert.Equal(1, result);

        }

        [Fact]
        public void Peek_works()
        {
            // arrange
            PseudoQueue<int> queue = new PseudoQueue<int>();
            queue.Enqueue(1);
           
            // act
            queue.Enqueue(2);
            queue.Enqueue(3);
            int result = queue.Peek();

            // assert
            Assert.Equal(1, result);

        }





    }


    
}


