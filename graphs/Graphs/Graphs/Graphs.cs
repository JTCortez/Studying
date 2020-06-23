using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Graphs
{
    public class Graphs
    {
        public Node[] nodes;
        public class Node {
            public string name;
            public List<Node> children;
            public bool visited;

            public Node(string val)
            {
                this.name = val;
                this.children = new List<Node>();
                this.visited = false;
            }
            
        }
        public void DFS(Node root)
        {
            Queue<Node> visited = new Queue<Node>();
            if (root == null)
            {
                return;
            }
            //current node now visited
            //root.visited = true;
            visited.Enqueue(root);
            Console.WriteLine(root.name);
            //go through each node's children, if haven't been seen recurse
            foreach (Node child in root.children)
            {
                //if (child.visited == false)
                if (!visited.Contains(child))
                {
                    DFS(child);
                }
            }
        }

        public void BFS(Node root)
        {
            Queue<Node> queue = new Queue<Node>();
            Queue<Node> visited = new Queue<Node>();
            //root.visited = true;
            queue.Enqueue(root);
            visited.Enqueue(root);

            while (queue.Count > 0)
            {
                Node cur = queue.Dequeue();
                Console.WriteLine(cur.name);
                foreach (Node child in cur.children)
                {
                    //if (child.visited == false)
                    if (!visited.Contains(child))
                    {
                        //child.visited = true;
                        visited.Enqueue(child);
                        queue.Enqueue(child);
                    }
                }
            }
        }

        public static int GetNumberOfIslands(int[,] binaryMatrix)
        {
            // your code goes here
            //bool[,] boolMatrix = new bool[binaryMatrix.GetLength(0),binaryMatrix[0].Length]();
            int islands = 0;


            for (int row = 0; row <= binaryMatrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col <= binaryMatrix.GetLength(1) - 1; col++)
                {
                    if (binaryMatrix[row, col] == 1)
                    {
                        //Console.WriteLine("{0}, {1}", binaryMatrix.GetLength(0) - 1, binaryMatrix.GetLength(1) - 1);
                        checkAdjacent(row, col, binaryMatrix);
                        islands += 1;
                    }
                }
            }
            return islands;
        }

        public static void checkAdjacent(int row, int col, int[,] binaryMatrix)
        {
            Queue<List<int>> q = new Queue<List<int>>();
            q.Enqueue(new List<int> { row, col });

            while (q.Count > 0)
            {
                List<int> cur = q.Dequeue();
                int r = cur[0];
                int c = cur[1];

                if (binaryMatrix[r, c] == 1)
                {
                    binaryMatrix[r, c] = -1;
                    //check each direction
                    validToQueue(q, r, c - 1, binaryMatrix);
                    validToQueue(q, r, c + 1, binaryMatrix);
                    validToQueue(q, r - 1, c, binaryMatrix);
                    validToQueue(q, r + 1, c, binaryMatrix);
                }
            }

            for (int rows = 0; rows < binaryMatrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < binaryMatrix.GetLength(1); cols++)
                {
                    Console.Write("{0}, ", binaryMatrix[rows, cols]);
                }
                Console.WriteLine("");
            }
            /* DFS ATTEMPT*/
            //if there is right
            //if there is below
            //if it's 0 or not

            //Console.WriteLine("{0}, {1},{2}, {3}", row <= binaryMatrix.GetLength(0) - 1, col < binaryMatrix.GetLength(1), row >= 0, col >= 0);
            //if (binaryMatrix[row, col] == 0) return;

            //if (binaryMatrix[row, col] == 1) binaryMatrix[row, col] = -1;
            //if (binaryMatrix[row, col] == -1)
            //{
            //    if (col + 1<binaryMatrix.GetLength(1) - 1) checkAdjacent(row, col + 1, binaryMatrix);
            //    if (row + 1 < binaryMatrix.GetLength(0) - 1) checkAdjacent(row + 1, col, binaryMatrix);
            //    if (col-1 >= 0) checkAdjacent(row, col - 1, binaryMatrix);
            //    if (row-1 >= 0) checkAdjacent(row - 1, col, binaryMatrix);
            //}
        }

        public static void validToQueue(Queue<List<int>> q, int row, int col, int[,] binaryMatrix)
        {
            int maxRow = binaryMatrix.GetLength(0) - 1;
            int maxCol = binaryMatrix.GetLength(1) - 1;
            if (row <= maxRow && col <= maxCol && row >= 0 && col >= 0)
            {
                q.Enqueue(new List<int> { row, col });
            }

        }

    }
}
