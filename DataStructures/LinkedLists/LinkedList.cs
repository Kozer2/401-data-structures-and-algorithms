using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedLists
{
   public class LinkedList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }

        public void Insert(int value)
        {
            Head = new Node(value);
            bool test = Head is not null;
            Head.Next = Current;
            Current = Head;
        }

        public bool Includes(int value)
        {
            // needs to return true if value is found in a node
           Node Current = Head;
            if(Current is null)
            {
                return false;
            }
            do // end if
            {
                if (Current.Value == value) 
                {
                    return true;
                } // end if
                else if (Current.Next is null)
                {
                    return false;
                } // end else if
                else
                {
                    Current = Current.Next;
                } // end else
            } while (true);

        }

        public override string ToString()
        {
            Current = Head;
            string result = "";
            if (Current is null)
                return null;
            while (Current != null)
            {
                result += $"{Current.Value},";
                Current = Current.Next;
            } // end while
            result += " null";

            return result;
        }


        public void Append(int value)
        {
            Node current = Head;
            Node newNode = new Node(value);
            while (!(current.Next is null))
            {
                current = current.Next;
            } // end while
            current.Next = newNode;
        }

        public void InsertBefore(int valueBefore, int newValue)
        {
            Node current = Head;
            Node newNode = new Node(newValue);
            if (current.Value == valueBefore)
            {
                newNode.Next = current;
                Head = newNode;
                return;
            } // end if

            while (current.Next.Value != valueBefore)
            {
                if (current.Next == null)
                {
                    throw new ArgumentException("No Value Found.");
                } // end if
                  
                current = current.Next;
            } // end while
            newNode.Next = current.Next;
            current.Next = newNode;
        }

        public void InsertAfter(int valueAfter, int newValue)
        {
            Node current = Head;
            Node newNode = new Node(newValue);
            while (current != null)
            {
                if (current.Value == valueAfter)
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    break;
                } // end if
                current = current.Next;
            } // end while
            throw new ArgumentException("No Value Found.");
        }

    }
}
