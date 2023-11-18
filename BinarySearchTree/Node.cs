namespace BinarySearchTree
{
    public class Node
    {
        public int Key;
        public char Value;
        public Node Left;
        public Node Right;

        public Node(int key, char value)
        {
            Key = key;
            Left = null;
            Right = null;
            Value = value;
        }
    }
}
