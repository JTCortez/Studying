using System;
using System.Collections.Generic;
using System.Linq;
using static Graphs.Graphs;

namespace Graphs
{
    public class Program
    {
        static void Main(string[] args)
        {
            Graphs graph = new Graphs();
            Node oneNode = new Node("0");
            Node twoNode = new Node("1");
            Node threeNode = new Node("2");
            Node fourNode = new Node("3");
            Node fiveNode = new Node("4");
            Node sixNode = new Node("5");
            Node sevenNode = new Node("6");
            Node eighthNode = new Node("7");
            Node nineNode = new Node("8");

            oneNode.children.Add(twoNode);
            oneNode.children.Add(fourNode);
            oneNode.children.Add(sevenNode);
            //Console.WriteLine(oneNode.children[1].name);
            twoNode.children.Add(threeNode);
            threeNode.children.Add(fourNode);
            threeNode.children.Add(fiveNode);
            fourNode.children.Add(sixNode);
            fiveNode.children.Add(sixNode);
            fiveNode.children.Add(nineNode);
            sevenNode.children.Add(nineNode);
            nineNode.children.Add(eighthNode);

            //graph.DFS(oneNode);

            //Console.WriteLine(Graphs.GetNumberOfIslands(new int[,] { { 1, 0, 1, 0 }, { 0, 1, 1, 1 }, { 0, 0, 1, 0 } }));
            graph.BFS(oneNode);



            int[,] arr = new int[,] { { 1, 0, 1, 0 }, { 0, 1, 1, 1 }, { 0, 0, 1, 0 } };
            Console.WriteLine("islands");
            Console.WriteLine(Graphs.GetNumberOfIslands(arr));
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    Console.Write("{0}, ", arr[row, col]);
                }
                Console.WriteLine("");
            }
        }
    }
}
