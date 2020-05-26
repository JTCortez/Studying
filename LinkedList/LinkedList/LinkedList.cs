using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedList
    {
        public class Node
        {
            public int val { get; set; }
            public Node Next;

            public Node(int val)
            {
                this.val = val;
                this.Next = null;
            }

        }

        public Node head = null;

        public LinkedList()
        {
            this.head = null;
            head.Next = null;
        }

        public LinkedList(int val)
        {
            this.head = new Node(val) ;
        }

        public void insertAtFront(int val)
        {
            Node newNode = new Node(val);

            newNode.Next = this.head;
            this.head = newNode;
        }

        public void printList()
        {
            Node cur = this.head;
            while (cur != null)
            {
                Console.Write(cur.val + "->");
                cur = cur.Next;
            }
        }
    }
}
