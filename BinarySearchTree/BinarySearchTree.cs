namespace BinarySearchTree
{
    public class BinarySearchTree
    {
        public Node Root;

        public BinarySearchTree()
        {
            Root = null;
        }

        public void Insert(int key, char value)
        {
            Root = InsertNode(Root, key, value);
        }

        private Node InsertNode(Node root, int key, char value)
        {
            if (root == null)
            {
                root = new Node(key, value);
                return root;
            }

            if (key < root.Key)
            {
                root.Left = InsertNode(root.Left, key, value);
            }
            else if (key > root.Key)
            {
                root.Right = InsertNode(root.Right, key, value);
            }

            return root;
        }
    }
}
