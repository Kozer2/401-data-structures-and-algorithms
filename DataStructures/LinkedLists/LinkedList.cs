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
            Current = Head;
            if(Current is null)
            {
                return false;
            }
            do
            {
                if (Current.Value == value) 
                {
                    return true;
                }
                else if (Current.Next is null)
                {
                    return false;
                }
                else
                {
                    Current = Current.Next;
                }
            } while (true);
        }

        public override string ToString()
        { 
            
            return "NULL";

        }


        public void append(int value)
        {
            if(Head == null)
            {
                Head = value;
                Head.Next = null;
            }

        }
    }
}
