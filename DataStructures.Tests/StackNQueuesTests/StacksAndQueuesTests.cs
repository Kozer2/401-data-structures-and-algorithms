using DataStructures.StackNQueue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataStructures.Tests.StackNQueue
{
    
    public class StacksAndQueuesTests
    {
        [Fact]
        public void Stack_starts_with_empty_list()
        {
            // arrange
            DataStructures.StackNQueue.Stack<int> stack = new DataStructures.StackNQueue.Stack<int>();

            // act

            // assert
            Assert.True(stack.isEmpty());
        }

        [Fact]
        public void Push_adds_top_to_value()
        {
            // arrange
            DataStructures.StackNQueue.Stack<int> stack = new DataStructures.StackNQueue.Stack<int>();
            // act
            stack.Push(1);
            // assert
            Assert.False(stack.isEmpty());
        }

        




    }


}

