using System;
using System.Collections.Generic;
using System.Text;

namespace listofdepths
{
    class listofdepths
    {
        public class Node
        {
            public string name;
            public Node left;
            public Node right;
            public bool visited;

            public Node(string val)
            {
                this.name = val;
                this.left = null;
                this.right = null;
                this.visited = false;
            }

        }

        public List<LinkedList<Node>> listOfDepths(Node root)
        {
            List<LinkedList<Node>> finalList = new List<LinkedList<Node>>();
            LinkedList<Node> depth = new LinkedList<Node>();

            if (root != null)
            {
                depth.AddFirst(root);
                finalList.Add(depth);
            }

            for (int i=0; i < finalList.Count; i++)
            {
                LinkedList<Node> newDepth = new LinkedList<Node>();
                foreach (Node cur in finalList[i])
                {
                    if (cur.left != null) { newDepth.AddLast(cur.left); }
                    if (cur.right != null) { newDepth.AddLast(cur.right); }
                }
                finalList.Add(newDepth);
            }
            return finalList;
        }

    }
}
