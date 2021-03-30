using DataStructures.LinkedLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataStructures.Tests.LinkedLists
{
    
    public class LinkedListTests
    {

        [Fact]
        public void Empty_list_has_null_head()
        {
            // arrange / act
            LinkedList list = new LinkedList();


            // assert
            Assert.Null(list.Head);

           /* Assert.Equal("null", list.ToString());*/
        }



        [Fact]
        public void Insert_works_for_empty_list()
        {
            // arrange
            LinkedList list = new LinkedList();
            int value = 5;

            // act
            list.Insert(value);
            

            // assert
            // no longer empty
            Assert.NotNull(list.Head);

            // first node has expected value
            Assert.Equal(value, list.Head.Value);

            // first node next is null
            Assert.Null(list.Head.Next);

        }
        [Fact]
        public void Insert_works_for_list_that_is_not_empty()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Insert(5);

            int value = 3;

            // Act
            list.Insert(3);

            //Assert
            Assert.NotNull(list.Head);
            Assert.Equal(value, list.Head.Value);
            Assert.NotNull(list.Head.Next);
            Assert.Equal(5, list.Head.Next.Value);
        }

        [Fact]
        public void ToString_returns_null_with_empty_list()
        {
            // Arrange
            
            LinkedList list = new LinkedList();


            // Act
            string result = list.ToString();

            //Assert
            Assert.Null(result);

        }


        [Fact]
        public void ToString_returns_value_with_single_node_list()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Insert(4);


            // Act
            string result = list.ToString();


            //Assert
            Assert.Equal("4, null", result );

        }

        [Fact]
        public void ToString_returns_csv_with_list_greater_than_1()
        {
            // arange
            LinkedList list = new LinkedList();
            list.Insert(1);
            list.Insert(2);
            list.Insert(3);
  

            // act
            string result = list.ToString();

            // assert
            string expected = "3,2,1, null";
            Assert.Equal(expected, result);
        }






        [Theory]
        [InlineData(1, false)]
        [InlineData(2, true)]
        [InlineData(3, false)]

        public void Include_works(int valueToFind, bool expected)
        {
            // arrange
            LinkedList list = new LinkedList();
            list.Insert(2);
            list.Insert(4);

            // act
            bool result = list.Includes(valueToFind);

            //Assert
            Assert.Equal(expected, result);
        }


        [Fact]
        public void Append_adds_to_end_of_list()
        {
            // arrange
            LinkedList list = new LinkedList();
            list.Insert(1);
            list.Insert(2);
            list.Insert(3);

            // act
            list.Append(4);
            string result = list.ToString();

            // assert
            Assert.Equal("3,2,1,4, null", result);

        }

        [Fact]
        public void Append_adds_multiple_nodes_to_list()
        {
            // arrange
            LinkedList list = new LinkedList();
            list.Insert(1);
            list.Insert(2);
            list.Insert(3);

            // act
            list.Append(4);
            list.Append(5);
            list.Append(6);
            list.Append(1);
            string result = list.ToString();
            // assert
            Assert.Equal("3,2,1,4,5,6,1, null", result);
        }

        [Fact]
        public void InsertBefore_adds_node_infront_of_first_time_node_appears_with_same_value()
        {
            // arrange
            LinkedList list = new LinkedList();
            list.Insert(1);
            list.Insert(2);
            list.Insert(3);
            list.Insert(3);

            // act
            list.InsertBefore(3, 2);
            string result = list.ToString();

            // assert
            Assert.Equal("2,3,3,2,1, null", result);
        }

        [Fact]
        public void InsertBefore_adds_node_to_front_of_list()
        {
            // arrange
            LinkedList list = new LinkedList();
            list.Insert(1);

            // act
            list.InsertBefore(1, 100);
            string result = list.ToString();

            // assert
            Assert.Equal("100,1, null", result);
        }

    }


}

