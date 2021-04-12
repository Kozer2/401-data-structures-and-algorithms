using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.StackNQueue;

namespace Challenges.PseudoQueueChallenges
{
    public class PseudoQueue<T> : IQueue<T>
    {
        private DataStructures.StackNQueue.Stack<T> Storage = new DataStructures.StackNQueue.Stack<T>();
        private DataStructures.StackNQueue.Stack<T> Reverse = new DataStructures.StackNQueue.Stack<T>();
        public bool IsEmpty => Storage.isEmpty() && Reverse.isEmpty();

        public T Dequeue()
        {
            ReverseStorage(false);
            return Reverse.Pop();
        }

        public void Enqueue(T value)
        {
            ReverseStorage(true);
            Storage.Push(value);
        }

        public T Peek()
        {
            ReverseStorage(false);
            return Reverse.Peek();
            
        }

        private void ReverseStorage(bool input)
        {
            if (IsEmpty)
            {
                return;
            }
            if(input)
            {
                if(Storage.isEmpty())
                {
                    while (!Reverse.isEmpty())
                        Storage.Push(Reverse.Pop());
                }
                else
                {
                    if(Reverse.isEmpty())
                    {
                        while(!Storage.isEmpty())
                        {
                            Reverse.Push(Storage.Pop());
                        }
                    }
                }
            }
        }

    }


}
