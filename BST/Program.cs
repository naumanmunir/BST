using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            tree.AddNode(3);


            tree.Insert(tree.root, tree.AddNode(2));
            tree.Insert(tree.root, tree.AddNode(1));
            tree.Insert(tree.root, tree.AddNode(4));
            tree.Insert(tree.root, tree.AddNode(10));
            tree.Insert(tree.root, tree.AddNode(6));

            tree.Print(tree.root);

        }
    }

    public class Node
    {
        public int data;

        public Node leftNode;
        public Node rightNode;

        public Node(int d)
        {
            this.data = d;
            leftNode = null;
            rightNode = null;
        }
    }

    public class Tree
    {
        public Node root;
        static int count;

        public Tree()
        {
            root = null;
        }

        public Node AddNode(int data)
        {
            Node temp = new Node(data);
            if (root == null)
            {
                root = temp;
            }
            count++;

            return temp;
        }

        //public void Remove(Node root, )

        public void Insert(Node root, Node newNode)
        {
            while (root != null)
            {
                if (newNode.data > root.data)
                {
                    if (root.rightNode == null)
                    {
                        root.rightNode = newNode;
                        break;
                    }

                    root = root.rightNode;
                }
                else
                {
                    if (root.leftNode == null)
                    {
                        root.leftNode = newNode;
                        break;
                    }
                    root = root.leftNode;
                }
            }

        }

        public void Print(Node root)
        {
            if(root != null)
            {
                Print(root.leftNode);
                Console.WriteLine(root.data + " ");
                Print(root.rightNode);
            }
        }
    }
}
