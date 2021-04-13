using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.StackNQueue
{
    public class Queue<T> : IQueue<T>
    {
        private Node<T> Front { get; set; }
        private Node<T> End { get; set; } 
        public bool IsEmpty => Front == null;

        public void Enqueue(T value)
        {
            Node<T> node = new Node<T>(value);
            if (Front == null)
                Front = node;
            else
                End.Next = node;
            End = node;
        }
        public T Dequeue()
        {
            T result = Front.Value;
            if (Front == End) 
                End = null;
            Front = Front.Next;
            return result;
        }
        public T Peek()
        {
            return Front.Value;
        }
    }
}
