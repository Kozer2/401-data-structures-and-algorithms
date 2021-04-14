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

        public IEnumerable<int> BreadthFirst()
        {
            // queue
            var breadth = new Queue<Node>();
            
            breadth.Enqueue(Root);

            // while
            while(breadth.Count > 0)
            {
                var front = breadth.Dequeue();

                if (front == null)
                    continue;

                yield return front.Value;

                if (front.Left != null)
                    breadth.Enqueue(front.Left);

                if (front.Right != null)
                    breadth.Enqueue(front.Right);
            }
            /*yield break;*/
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
  
        // max code
        /*public int MaxNode(Node node)
        {
            if (node == null) throw new InvalidOperationException();

            if(node.Left!= null)
            {
                int maxLeft = MaxNode(node.Left);
                if (maxLeft > maxLeft)
                    max = maxLeft;
            }
        }*/




    }

    public class Node 
    {
        // Stretch goal: make this generic
        public int Value { get; set; }

        public Node Left { get; set; }
        public Node Right { get; set; }
    }
}
