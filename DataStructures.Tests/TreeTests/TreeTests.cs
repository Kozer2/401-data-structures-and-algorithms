using DataStructures.StackNQueue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DataStructures.Trees;

namespace DataStructures.Tests.TreeTests
{

    public class TreeTests
    {

        [Fact]
        public void Root_works_to_create_new_Tree_with_no_node()
        {

            // arrange
            BinaryTree tree = new BinaryTree();

            // act
            tree.Root = new Node();

            string preOrder = string.Join(", ", tree.PreOrder());

            // assert
            Assert.Equal("0", preOrder);

        }

        [Fact]
        public void Root_works_to_create_new_Tree_with_single_node()
        {

            // arrange
            BinaryTree tree = new BinaryTree();

            // act
            tree.Root = new Node();
            tree.Root.Value = 3;

            string preOrder = string.Join(", ", tree.PreOrder());

            // assert
            Assert.Equal("3", preOrder);

        }


        [Fact]
        public void Root_works_to_create_new_Tree_and_preorder_works()
        {

            // arrange
            BinaryTree tree = new BinaryTree();

            // act
            tree.Root = new Node();
            tree.Root.Value = 3;
            tree.Root.Left = new Node();
            tree.Root.Left.Value = 4;
            tree.Root.Right = new Node();
            tree.Root.Right.Value = 5;

            string preOrder = string.Join(", ", tree.PreOrder());

            // assert
            Assert.Equal("3, 4, 5", preOrder);

        }

        [Fact]
        public void Inorder_works_to_create_new_Tree_with_no_node()
        {

            // arrange
            BinaryTree tree = new BinaryTree();

            // act
            tree.Root = new Node();

            string inOrder = string.Join(", ", tree.InOrder());

            // assert
            Assert.Equal("0", inOrder);

        }



        [Fact]
        public void InOrder_works_with_single_node()
        {

            // arrange
            BinaryTree tree = new BinaryTree();

            // act
            tree.Root = new Node();
            tree.Root.Value = 5;

            string inOrder = string.Join(", ", tree.InOrder());

            // assert
            Assert.Equal("5", inOrder);

        }

        [Fact]
        public void inOrder_works_to_create_new_Tree_with_left_and_right_branches()
        {

            // arrange
            BinaryTree tree = new BinaryTree();

            // act
            tree.Root = new Node();
            tree.Root.Value = 3;
            tree.Root.Left = new Node();
            tree.Root.Left.Value = 4;
            tree.Root.Right = new Node();
            tree.Root.Right.Value = 5;

            string inOrder = string.Join(", ", tree.InOrder());

            // assert
            Assert.Equal("4, 3, 5", inOrder);

        }


        [Fact]
        public void PostOrder_works_to_create_new_Tree_with_left_and_right_branches()
        {

            // arrange
            BinaryTree tree = new BinaryTree();

            // act
            tree.Root = new Node();
            tree.Root.Value = 3;
            tree.Root.Left = new Node();
            tree.Root.Left.Value = 4;
            tree.Root.Right = new Node();
            tree.Root.Right.Value = 5;

            string postOrder = string.Join(", ", tree.PostOrder());

            // assert
            Assert.Equal("4, 5, 3", postOrder);

        }

        [Fact]
        public void PostOrder_works_with_single_node()
        {

            // arrange
            BinaryTree tree = new BinaryTree();

            // act
            tree.Root = new Node();
            tree.Root.Value = 5;

            string postOrder = string.Join(", ", tree.PostOrder());

            // assert
            Assert.Equal("5", postOrder);

        }


        [Fact]
        public void PostOrder_works_to_create_new_Tree_with_no_node()
        {

            // arrange
            BinaryTree tree = new BinaryTree();

            // act
            tree.Root = new Node();

            string postOrder = string.Join(", ", tree.PostOrder());

            // assert
            Assert.Equal("0", postOrder);

        }

        [Fact]
        public void BreadthFirst_returns_empty_tree()
        {
            // arrange
            var tree = new BinaryTree();

            // act
            var result = tree.BreadthFirst();

            // assert
            Assert.Empty(result);
        }

        [Fact]
        public void BreadthFirst_returns_root_for_tree_with_1_thing()
        {
            // arrange
            var tree = new BinaryTree();
            tree.Root = new Node { Value = 5 };

            // act
            var result = tree.BreadthFirst();

            // assert
            Assert.Equal(new[] { 5 }, result);
        }

        [Fact]
        public void BreadthFirst_works_for_big_tree()
        {
            // arrange
            var tree = new BinaryTree();
            tree.Root = new Node { Value = 2 };
            tree.Root.Left = new Node { Value = 7 };
            tree.Root.Left.Left = new Node { Value = 2 };
            tree.Root.Left.Right = new Node
            {
                Value = 6,
                Left = new Node { Value = 5 },
                Right = new Node { Value = 11 },
            };
            tree.Root.Right = new Node
            {
                Value = 5,
                Right = new Node
                {
                    Value = 9,
                    Left = new Node
                    {
                        Value = 4
                    }
                }
            };

            // act
            var result = tree.BreadthFirst();

            // assert
            Assert.Equal(new[] { 2, 7, 5, 2, 6, 9, 5, 11, 4 }, result);
        }

    }

}

