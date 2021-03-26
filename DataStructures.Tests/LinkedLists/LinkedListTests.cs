﻿using DataStructures.LinkedLists;
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

            Assert.Equal("NULL", list.ToString());
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

        [Theory]
        [InlineData(1, false)]
        [InlineData(2, true)]
        [InlineData(3, true)]

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



    }


}

