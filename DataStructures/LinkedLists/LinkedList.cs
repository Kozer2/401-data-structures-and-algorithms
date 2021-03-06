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
                current = current.Next;
            } // end while
            newNode.Next = current.Next;
            current.Next = newNode;
        }

        public void InsertAfter(int valueAfter, int newValue)
        {
            Current = Head;
            Node newNode = new Node(newValue);
            while (Current != null)
            {
                if (Current.Value == valueAfter)
                {
                    newNode.Next = Current.Next;
                    Current.Next = newNode;
                    return;
                } // end if
                Current = Current.Next;
            } // end while
        }

        public int KthFromEnd(int k)
        {
            Current = Head;

            if (k < 0)
            {
                throw new ArgumentException("Argument out of bounds!");
            } // end if

            if (Current == null)
            {
                throw new ArgumentException("Argument out of bounds!");
            }// end if

            for (int i = 0; i < k; i++)
            {
                if (Current.Next == null)
                {
                    throw new ArgumentException("Argument out of bounds!");
                } // end if
                Current = Current.Next;
            }// end for

            Node positionK = Head;
            while(Current != null)
            {
                if(Current.Next == null)
                {
                    return positionK.Value;
                } // end if
                Current = Current.Next;
                positionK = positionK.Next;
            }
            throw new ArgumentException("Who knows, just run.");
        }

    }
}
