namespace LeetCodeSolutions
{
    internal partial class _783_MinimumDistanceBetweenBSTNodes : ILeetCodeExecute
    {
        public void Execute()
        {
            TreeNode tree = new TreeNode(1);
            tree.left = new TreeNode(48);
            tree.right = new TreeNode(0);
            tree.left.left = new TreeNode(49);
            tree.left.right = new TreeNode(12);

            Console.WriteLine(MinDiffInBST(tree));
        }

        public int MinDiffInBST(TreeNode root)
        {
            int min = int.MaxValue;// max int value possible
            var list = new List<int>();
            inorder(root, list);
            for (int i = 0; i < list.Count -1; i=i+1)
            {
                if ((Math.Abs( list[i+1] - list[i])) < min)
                    min = Math.Abs(list[i+1] - list[i]);
            }
            return min;
        }

        void inorder(TreeNode root, List<int> A)
        {
            if (root == null)
                return;
            inorder(root.left, A);
            Console.WriteLine(root.val);
            A.Add(root.val);         //adding elements 
            inorder(root.right, A);
        }
    }
}
