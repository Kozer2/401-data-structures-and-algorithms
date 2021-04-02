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
            list.Insert(2);
            list.Insert(3);

            // act
            list.InsertBefore(1, 100);
            string result = list.ToString();

            // assert
            Assert.Equal("3,2,100,1, null", result);
        }

        [Fact]
        public void InsertAfter_adds_node_after_last_item_in_list()
        {
            // arrange
            LinkedList list = new LinkedList();
            list.Insert(1);
            list.Insert(2);
            list.Insert(3);
            list.Insert(4);

            // act
            list.InsertAfter(1, 5);
            string result = list.ToString();

            // assert
            Assert.Equal("4,3,2,1,5, null", result);
        }


        [Fact]
        public void Kth_from_end_inserting_at_Nth_point()
        {
            // arrange
            LinkedList list = new LinkedList();
            list.Insert(1);
            list.Insert(2);
            list.Insert(3);
            list.Insert(4);
            list.Insert(5);
 

            // act
            list.KthFromEnd(2);
            string result = list.ToString();

            // assert
            Assert.Equal("5,4,3,2,1, null", result);
        }

        [Fact]
        public void Kth_K_is_bigger_than_list()
        {
            // arrange
            LinkedList list = new LinkedList();
            list.Insert(1);
            list.Insert(2);
            list.Insert(3);
            list.Insert(4);
            list.Insert(5);


            // assert
            Assert.Throws<ArgumentException>(() =>
            {
                // act
                list.KthFromEnd(8);
                string result = list.ToString();

            });
        }


        [Fact]
        public void Kth_K_and_list_are_same_size()
        {
            // arrange
            LinkedList list = new LinkedList();
            list.Insert(1);
            list.Insert(2);
            list.Insert(3);
            list.Insert(4);
            list.Insert(5);


            // act
            list.KthFromEnd(4);
            string result = list.ToString();

            // assert
            Assert.Equal("5,4,3,2,1, null", result);
        }


        [Fact]
        public void Kth_K_is_negative()
        {
            // arrange
            LinkedList list = new LinkedList();
            list.Insert(1);
            list.Insert(2);
            list.Insert(3);

            // assert
            Assert.Throws<ArgumentException>(() =>
            {
                // act
                list.KthFromEnd(-5);
                string result = list.ToString();

            });
        }


        [Fact]
        public void Kth_list_is_size_1()
        {
            // arrange
            LinkedList list = new LinkedList();
            list.Insert(1);

            // assert
            Assert.Throws<ArgumentException>(() =>
            {
                // act
                list.KthFromEnd(1);
                string result = list.ToString();

            });
        }


        [Fact]
        public void Zip_method_works_and_zips_list()
        {
            // arrange
            LinkedList list = new LinkedList();
            list.Insert(1);

            // assert
            Assert.Throws<ArgumentException>(() =>
            {
                // act
                list.KthFromEnd(1);
                string result = list.ToString();

            });
        }


        [Fact]
        public void Ziplist_returns_list1_with_no_list2()
        {
            // arrange
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();
            list1.Insert(1);
            list1.Insert(2);
            list1.Insert(3);

            // act
            LinkedList result = LLZip.ZipLists(list1, list2);

            // assert
            Assert.Equal(list1, result);

        }

        [Fact]
        public void Ziplist_returns_list2_with_no_list1() 
        {
            // arrange
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();
            list2.Insert(1);
            list2.Insert(2);
            list2.Insert(3);

            // act
            LinkedList result = LLZip.ZipLists(list1, list2);

            // assert
            Assert.Equal(list2, result);

        }
  
        [Fact]
        public void ZipLists_works_and_zips_2_lists()
        {
            // arrange
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();
            list1.Insert(2);
            list1.Insert(3);
            list1.Insert(1);
            
            list2.Insert(4);
            list2.Insert(9);
            list2.Insert(5);


            // act
            LinkedList result = LLZip.ZipLists(list1, list2);

            // assert
            Assert.Equal("1,5,3,9,2,4, null", result.ToString());

        }




    }


}

