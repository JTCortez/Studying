using System;
using static LinkedList.LinkedList;
using static LinkedList.partition;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            partition p = new partition();

            LinkedList start = new LinkedList(1);
            start.insertAtFront(2);
            start.insertAtFront(10);
            start.insertAtFront(5);
            start.insertAtFront(8);
            start.insertAtFront(5);
            start.insertAtFront(3);
            start.printList();
            Console.WriteLine("new partition");
            p.partitionCheck(start, 5);
            start.printList();

        }
    }
}
