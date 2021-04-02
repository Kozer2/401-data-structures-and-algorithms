using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedLists
{
    public class LLZip
    {
        public static LinkedList ZipLists(LinkedList list1, LinkedList list2)
        {
            if (list1.Head == null) 
            {
                return list2;
            } // end if
            else if(list2.Head == null)
            {
                return list1;
            }

            Node Current1 = list1.Head;
            Node Current2 = list2.Head;
            Node tempHead;

            while (Current1 != null && Current2 != null)
            {
                tempHead = Current2.Next;
                Current2.Next = Current1.Next;
                Current1.Next = Current2;
                if (Current2.Next == null)
                {
                    Current2.Next = tempHead;
                    break;
                }
                Current1 = Current2.Next;
                Current2 = tempHead;
            }
            return list1;
        }
    }
}
