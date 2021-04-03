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

        // Stack tests

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
        public void Push_works_and_adds_value_to_top_of_stack()
        {
            // arrange
            DataStructures.StackNQueue.Stack<int> stack = new DataStructures.StackNQueue.Stack<int>();

            // act
            stack.Push(1);
            stack.Push(2);

            // assert
            Assert.False(stack.isEmpty());
            
        }

        [Fact]
        public void Pop_works_and_returns_correct_value()
        {
            // arrange
            DataStructures.StackNQueue.Stack<int> stack = new DataStructures.StackNQueue.Stack<int>();
            stack.Push(5);
            stack.Push(7);
            stack.Push(9);
            // act
            int result = stack.Pop();

            // assert
            Assert.Equal(9, result);
        }

        [Fact]
        public void Peek_works_and_returns_correct_value()
        {
            // arrange
            DataStructures.StackNQueue.Stack<int> stack = new DataStructures.StackNQueue.Stack<int>();
            stack.Push(5);
            stack.Push(7);
            stack.Push(9);

            // act
            int result = stack.Peek();

            // assert
            Assert.Equal(9, result);
        }


        [Fact]
        public void Calling_Pop_or_Peek_on_empty_stack_raises_exception()
        {
            // arrange
            DataStructures.StackNQueue.Stack<int> stack = new DataStructures.StackNQueue.Stack<int>();

            // assert
            Assert.True(stack.isEmpty());
            Assert.Throws<ArgumentException>(() =>
            {
                // act
                int result = stack.Peek();
                int result2 = stack.Pop();


            });
        }

        [Fact]
        public void Pop_empties_Stack_when_called_multiple_times()
        {
            // arrange
            DataStructures.StackNQueue.Stack<int> stack = new DataStructures.StackNQueue.Stack<int>();
            stack.Push(5);
            stack.Push(7);
            stack.Push(9);

            // act
            stack.Pop();
            stack.Pop();
            stack.Pop();

            // assert
            Assert.True(stack.isEmpty());
        }




        // Queue tests

    }


}

