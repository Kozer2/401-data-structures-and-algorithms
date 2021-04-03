using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.StackNQueue
{
    public class Stack<T>
    {
         Node<T> Top { get; set; }

        public Stack()
        {
            Top = null;
        }
        public void Push(T value)
        {
            Node<T> node = new Node<T>(value);

            node.Next = Top;

            Top = node;
        }

        public bool isEmpty()
        {
            return Top == null;
        }

        public T Pop()
        {
            T result = Top.Value;

            Top = Top.Next;

            return result;
        }
    }
}
