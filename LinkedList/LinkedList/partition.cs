using System;
using System.Collections.Generic;
using System.Text;
using static LinkedList.LinkedList;

namespace LinkedList
{
    class partition
    {
        public LinkedList partitionCheck(LinkedList list, int partition)
        {
            Node cur = list.head;
            Node prev = new Node(0);
            Node head = list.head;

            while (cur != null)
            {
                if (cur.val < partition && cur  != head)
                {
                    prev.Next = cur.Next;
                    cur.Next = head;
                    head = cur;
                    cur = prev.Next;
                }
                else
                {
                    prev = cur;
                    cur = cur.Next;
                }
            }
            list.head = head;
            return list;
        } 
    }
}
