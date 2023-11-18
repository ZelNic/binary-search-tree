using System;
using BinarySearchTree;

namespace BinarySearchTree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Insert(5, 'a');
            bst.Insert(3, 'b');
            bst.Insert(7, 'c');
            bst.Insert(2, 'd');
            bst.Insert(4, 'e');
            bst.Insert(6, 'f');
            bst.Insert(8, 'g');

            TreeHandler treeHandler = new TreeHandler();

            Console.WriteLine("Обход в глубину");
            Console.WriteLine();

            treeHandler.Preorder(bst.Root);
            Console.WriteLine(new string('-', 57));

            Console.WriteLine();
            Console.WriteLine("Обход в ширину");

            Console.WriteLine();
            treeHandler.BreadthFirstTraversal(bst.Root);
        }
    }
}