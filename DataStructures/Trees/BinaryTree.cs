using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Trees
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public List<int> PreOrder()
        {
            List<int> result = new List<int>();
            PreOrder(Root, result);
            return result;
        }
        private void PreOrder(Node node, List<int> result)
        {
            // Stretch goal: use yield return instead
            result.Add(node.Value);

            if (node.Left != null)
                PreOrder(node.Left, result);

            if (node.Right != null)
                PreOrder(node.Right, result);
        }

        // TODO: PostOrder, InOrder

        public List<int> InOrder()
        {
            List<int> result = new List<int>();
            InOrder(Root, result);
            return result;
        }
        private void InOrder(Node node, List<int> result)
        {
            // Stretch goal: use yield return instead
            
            if (node.Left != null)
                InOrder(node.Left, result);

            result.Add(node.Value);

            if (node.Right != null)
                InOrder(node.Right, result);
        }


        public List<int> PostOrder()
        {
            List<int> result = new List<int>();
            PostOrder(Root, result);
            return result;
        }
        private void PostOrder(Node node, List<int> result)
        {
            // Stretch goal: use yield return instead

            if (node.Left != null)
                PostOrder(node.Left, result);

            if (node.Right != null)
                PostOrder(node.Right, result);

            result.Add(node.Value);

            
        }





    }

    public class Node 
    {
        // Stretch goal: make this generic
        public int Value { get; set; }

        public Node Left { get; set; }
        public Node Right { get; set; }
    }
}
