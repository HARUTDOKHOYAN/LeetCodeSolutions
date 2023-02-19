using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static LeetCodeSolutions._783_MinimumDistanceBetweenBSTNodes;

namespace LeetCodeSolutions
{
    internal class _226_InvertBinaryTree : ILeetCodeExecute
    {

        public TreeNode InvertTree(TreeNode root)
        {
            preOrder(root);
            return root;
        }

        void preOrder(TreeNode root)
        {
            if (root == null)
                return;

            (root.left, root.right) = (root.right, root.left);

            preOrder(root.left);

            preOrder(root.right);
        }


        public void Execute()
        {
            var tree = new TreeNode(1);
            tree.left = new TreeNode(2);
            tree.right = new TreeNode(3);
            tree.left.left = new TreeNode(4);
            tree.left.right = new TreeNode(5);

            InvertTree(tree);
        }
    }
}
