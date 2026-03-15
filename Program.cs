namespace BST_Binary_Tree_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(50);

            root.left = new TreeNode(30);
            root.right = new TreeNode(70);

            root.left.left = new TreeNode(20);
            root.left.right = new TreeNode(40);

            root.right.left = new TreeNode(60);
            root.right.right = new TreeNode(80);

            Program p = new Program();
            TreeNode result = p.SearchBST(root, 60);

            if (result != null)
            {
                Console.WriteLine("Found node: " + result.val);
            }
            else
            {
                Console.WriteLine("Value not found");
            }
            Console.ReadLine();
        }
        public TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null)
            {
                return null;
            }

            if (root.val == val)
            {
                return root;
            }

            if (val < root.val)
            {
                return SearchBST(root.left, val);
            }
            else
            {
                return SearchBST(root.right, val);
            }
        }

    }
}
