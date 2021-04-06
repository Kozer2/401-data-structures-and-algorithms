using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.StackNQueue;

namespace Challenges.AnimalShelter
{
    public class AnimalShelter<T> : IQueue<T>
    {

        private DataStructures.StackNQueue.Stack<T> Storage = new DataStructures.StackNQueue.Stack<T>();
        private DataStructures.StackNQueue.Stack<T> ReverseStack = new DataStructures.StackNQueue.Stack<T>();
        private DataStructures.StackNQueue.Stack<T> Holding = new DataStructures.StackNQueue.Stack<T>();

 

        public bool IsEmpty => Storage.isEmpty() && ReverseStack.isEmpty();

        public T Dequeue()
        {
          
            return ReverseStack.Pop();
        }

        public void Enqueue(T value)
        {
       
            Storage.Push(value);
        }

        public T Peek()
        {
            throw new NotImplementedException();
        }
    }
}
