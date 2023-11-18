using System;
using System.Collections.Generic;

namespace BinarySearchTree
{
    public class TreeHandler
    {
        public void Preorder(Node root)
        {
            if (root != null)
            {
                Console.WriteLine("Значение текущего узла: " + root.Key);
                if (root.Left != null)
                {
                    Console.WriteLine("Левый потомок: " + root.Left.Value);
                }
                if (root.Right != null)
                {
                    Console.WriteLine("Правый потомок: " + root.Right.Value);
                }
                Preorder(root.Left);
                Preorder(root.Right);
            }
        }

        public void BreadthFirstTraversal(Node root)
        {
            if (root == null)
            {
                return;
            }

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                Node current = queue.Dequeue();

                Console.WriteLine("Узел: " + current.Key);
                Console.WriteLine("Значение текущего узла: " + current.Value);
                if (current.Left != null)
                {
                    queue.Enqueue(current.Left);
                    Console.WriteLine("Левый потомок: " + current.Left.Value);
                }

                if (current.Right != null)
                {
                    queue.Enqueue(current.Right);
                    Console.WriteLine("Правый потомок: " + current.Right.Value);

                }
            }
        }
    }
}
