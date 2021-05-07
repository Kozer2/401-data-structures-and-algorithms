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
            graph tree = new graph();

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
            graph tree = new graph();

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
            graph tree = new graph();

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
            graph tree = new graph();

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
            graph tree = new graph();

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
            graph tree = new graph();

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
            graph tree = new graph();

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
            graph tree = new graph();

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
            graph tree = new graph();

            // act
            tree.Root = new Node();

            string postOrder = string.Join(", ", tree.PostOrder());

            // assert
            Assert.Equal("0", postOrder);

        }


    }

}

