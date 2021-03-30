# 401-data-structures-and-algorithms

Table of Contents
- [Lab 1](https://github.com/Kozer2/401-data-structures-and-algorithms/blob/main/Challenges/ArrayChallenges/ArrayReverse.cs)
- [Lab2](https://github.com/Kozer2/401-data-structures-and-algorithms/blob/main/Challenges/ArrayChallenges/ArrayShift.cs)
- [Lab3](https://github.com/Kozer2/401-data-structures-and-algorithms/blob/main/Challenges/ArrayChallenges/BinarySearch.cs)
- [Lab4](https://github.com/Kozer2/401-data-structures-and-algorithms/tree/main/DataStructures/LinkedLists)



# Reverse an Array
This console app takes an array of an indeterminate length and then reverses it and returns it back to the user. 

## Challenge
For this code challenge we were told to write a method that would take an array and return it reversed.

## Approach & Efficiency
Our solution increases linearly as the array length increases. It is O^n.

## Solution
We went as simple as we could. Here is a picture of our whiteboard.


![My Groups Whiteboard](assests/whiteboard-1.PNG "Whiteboard")




# Insert Shift Array
This function takes a given input number and inserts it into the middle point of an array.

## Challenge
Write a function called insertShiftArray which takes in an array and the value to be added. Without utilizing any of the built-in methods available to your language, return an array with the new value added at the middle index.

## Approach & Efficiency
Our solution increases linearly as the array length increases. It is O n

## Solution
Our solution to this was to find and store the middle of the array and then compare the numbers in the array to that variable. Once it was larger than a number in the array we inserted the given number. 

https://github.com/Kozer2/401-data-structures-and-algorithms/blob/main/Challenges/ArrayChallenges/ArrayShift.cs
![My Groups Whiteboard](assests/Whiteboard-2.PNG "Whiteboard")



# Binary Array Search
This function uses binary search to sort through arrays

## Challenge
Write a function called BinarySearch which takes in 2 parameters: a sorted array and the search key. Without utilizing any of the built-in methods available to your language, return the index of the array’s element that is equal to the search key, or -1 if the element does not exist.

## Approach & Efficiency
We looked at this with O(log n) and knew we needed to find the small starting number, the max number, and the mid. 

## Solution
To find the mid Number I took the max number, added the minimium to it and then divided them by 2.
https://github.com/Kozer2/401-data-structures-and-algorithms/blob/main/Challenges/ArrayChallenges/BinarySearch.cs
![My Groups Whiteboard](assests/Whiteboard-3.jpeg "Whiteboard")





# Singly Linked List
Working with Linked Lists create basic tests that insert to Linked Lists. 

## Challenge
Create a Node class that has properties for the value stored in the Node, and a pointer to the next Node.
Within your LinkedList class, include a head property. Upon instantiation, an empty Linked List should be created.
Define a method called insert which takes any value as an argument and adds a new node with that value to the head of the list with an O(1) Time performance.
Define a method called includes which takes any value as an argument and returns a boolean result depending on whether that value exists as a Node’s value somewhere within the list.
Define a method called toString (or __str__ in Python) which takes in no arguments and returns a string representing all the values in the Linked List, formatted as:
"{ a } -> { b } -> { c } -> NULL"
Any exceptions or errors that come from your code should be semantic, capturable errors. For example, rather than a default error thrown by your language, your code should raise/throw a custom, semantic error that describes what went wrong in calling the methods you wrote for this lab.
Be sure to follow your language/frameworks standard naming conventions (e.g. C# uses PascalCasing for all method and class names).

## Approach & Efficiency
Big On



# Linked List
Work over Linked Lists

## Challenge
Write the following methods for the Linked List class:

.append(value) which adds a new node with the given value to the end of the list
.insertBefore(value, newVal) which add a new node with the given newValue immediately before the first value node
.insertAfter(value, newVal) which add a new node with the given newValue immediately after the first value node

## Approach & Efficiency


## Solution


![My Groups Whiteboard](assests/whiteboard-4.jpeg "Whiteboard")
