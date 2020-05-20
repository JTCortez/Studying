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
            if (root == null)
            {
                return;
            }
            //current node now visited
            root.visited = true;
            Console.WriteLine(root.name);
            //go through each node's children, if haven't been seen recurse
            foreach (Node child in root.children)
            {
                if (child.visited == false)
                {
                    DFS(child);
                }
            }
        }

        public void BFS(Node root)
        {
            Queue<Node> queue = new Queue<Node>();
            root.visited = true;
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                Node cur = queue.Dequeue();
                Console.WriteLine(cur.name);
                foreach (Node child in cur.children)
                {
                    if (child.visited == false)
                    {
                        child.visited = true;
                        queue.Enqueue(child);
                    }
                }
            }
        }

    }
}
