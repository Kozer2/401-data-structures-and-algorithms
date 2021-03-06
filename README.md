



# 401-data-structures-and-algorithms
Links to Code:   
[Array Challenges](https://github.com/Kozer2/401-data-structures-and-algorithms/tree/main/Challenges/ArrayChallenges)
[Pseudo Queue](https://github.com/Kozer2/401-data-structures-and-algorithms/tree/main/Challenges/PseudoQueueChallenges)
[Linked List](https://github.com/Kozer2/401-data-structures-and-algorithms/tree/main/DataStructures/LinkedLists)
[Stack and Queue](https://github.com/Kozer2/401-data-structures-and-algorithms/tree/main/DataStructures/StackNQueue)  
[Trees](https://github.com/Kozer2/401-data-structures-and-algorithms/tree/main/DataStructures/Trees)
[Animal Shelter](https://github.com/Kozer2/401-data-structures-and-algorithms/tree/main/Challenges/AnimalShelter)  
[MultiBracket](https://github.com/Kozer2/401-data-structures-and-algorithms/blob/main/Challenges/MultiBracketChallenge/MultiBracketValidation.cs)   
[BinaryTree](https://github.com/Kozer2/401-data-structures-and-algorithms/blob/main/DataStructures/Trees/BinaryTree.cs)





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


![My Groups Whiteboard](assests/Whiteboard-2.PNG "Whiteboard")



# Binary Array Search
This function uses binary search to sort through arrays

## Challenge
Write a function called BinarySearch which takes in 2 parameters: a sorted array and the search key. Without utilizing any of the built-in methods available to your language, return the index of the array???s element that is equal to the search key, or -1 if the element does not exist.

## Approach & Efficiency
We looked at this with O(log n) and knew we needed to find the small starting number, the max number, and the mid. 

## Solution
To find the mid Number I took the max number, added the minimium to it and then divided them by 2.

![My Groups Whiteboard](assests/Whiteboard-3.jpeg "Whiteboard")





# Singly Linked List
Working with Linked Lists create basic tests that insert to Linked Lists. 

## Challenge
Create a Node class that has properties for the value stored in the Node, and a pointer to the next Node.
Within your LinkedList class, include a head property. Upon instantiation, an empty Linked List should be created.
Define a method called insert which takes any value as an argument and adds a new node with that value to the head of the list with an O(1) Time performance.
Define a method called includes which takes any value as an argument and returns a boolean result depending on whether that value exists as a Node???s value somewhere within the list.
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





# Challenge Summary
We need to write a method with associated tests that takes a number, K, and returns what is at that position in the list.

## Challenge Description
Write a method for the Linked List class which takes a number, k, as a parameter. Return the node???s value that is k from the end of the linked list. You have access to the Node class and all the properties on the Linked List class as well as the methods created in previous challenges.

## Approach & Efficiency
The Big O for this is On

## Solution
![My Groups Whiteboard](assests/Whiteboard-5.jpeg "Whiteboard")




# Challenge Summary
Our challenge for today is to write a method that will take 2 linked lists and zip them together without making a new list.

## Challenge Description
Write a function called zipLists which takes two linked lists as arguments. Zip the two linked lists together into one so that the nodes alternate between the two lists and return a reference to the head of the zipped list. Try and keep additional space down to O(1). You have access to the Node class and all the properties on the Linked List class as well as the methods created in previous challenges.

## Approach & Efficiency
We want to keep it close to Big On

## Solution
![My Groups Whiteboard](assests/Whiteboard-6.jpeg "Whiteboard")




# Stacks and Queues
Write methods that will add to a stack and show proper queuing

## Challenge
Create a Node class that has properties for the value stored in the Node, and a pointer to the next node.  
Create a Stack class that has a top property. It creates an empty Stack when instantiated.  
This object should be aware of a default empty value assigned to top when the stack is created.  
Define a method called push which takes any value as an argument and adds a new node with that value to the top of the stack with an O(1) Time performance.  
Define a method called pop that does not take any argument, removes the node from the top of the stack, and returns the node???s value.  
Should raise exception when called on empty stack  
Define a method called peek that does not take an argument and returns the value of the node located on top of the stack, without removing it from the stack.  
Should raise exception when called on empty stack  
Define a method called isEmpty that takes no argument, and returns a boolean indicating whether or not the stack is empty.


Create a Queue class that has a front property. It creates an empty Queue when instantiated.  
This object should be aware of a default empty value assigned to front when the queue is created.  
Define a method called enqueue which takes any value as an argument and adds a new node with that value to the back of the queue with an O(1) Time performance.  
Define a method called dequeue that does not take any argument, removes the node from the front of the queue, and returns the node???s value.  
Should raise exception when called on empty queue  
Define a method called peek that does not take an argument and returns the value of the node located in the front of the queue, without removing it from the queue.  
Should raise exception when called on empty queue  
Define a method called isEmpty that takes no argument, and returns a boolean indicating whether or not the queue is empty.  

Be sure to follow your languages best practices for naming conventions.  
You have access to the Node class and all the properties on the Linked List class.

## Approach & Efficiency
The Stack should be Big O(1)

## API
Check StacksAndQUeuesTests 



# Challenge 11
# Challenge Summary
Create a new class and using enqueue() and dequeue() add and pop values from a stack

## Challenge Description
Feature Tasks
Create a brand new PseudoQueue class. Do not use an existing Queue. Instead, this PseudoQueue class will implement our standard queue interface (the two methods listed below), but will internally only utilize 2 Stack objects. Ensure that you create your class with the following methods:

enqueue(value) which inserts value into the PseudoQueue, using a first-in, first-out approach.
dequeue() which extracts a value from the PseudoQueue, using a first-in, first-out approach.
The Stack instances have only push, pop, and peek methods. You should use your own Stack implementation. Instantiate these Stack objects in your PseudoQueue constructor.

## Approach & Efficiency
This is Big O^2

## Solution
![My Groups Whiteboard](assests/Whiteboard-7.PNG "Whiteboard")


# Challenge 12
# Challenge Summary
Using Enqueue() and Dequeue() populate an AnimalShelter and remove dogs or cats on a FIFO basis. 

## Challenge Description
Create a class called AnimalShelter which holds only dogs and cats. The shelter operates using a first-in, first-out approach.
Implement the following methods:
enqueue(animal): adds animal to the shelter. animal can be either a dog or a cat object.
dequeue(pref): returns either a dog or a cat. If pref is not "dog" or "cat" then return null.

## Approach & Efficiency
This is Big O^2

## Solution
![My Groups Whiteboard](assests/Whiteboard-8.PNG "Whiteboard")




# Challenge 13
# Challenge Summary
Create a stack with a method that takes in a string. This string will contain opening and closing brackets \[,\{,\(,\),\},\]. 
If they are balanced return true. Otherwise return false. 

## Challenge Description
On your main file, create???
C#: a method called public static bool MultiBracketValidation(string input)
JavaScript: a function called multiBracketValidation(input)
Python: a function called multi_bracket_validation(input)
Java: a method public static boolean multiBracketValidation(String input)
Your function should take a string as its only argument, and should return a boolean representing whether or not the brackets in the string are balanced. There are 3 types of brackets:

Round Brackets : \(\)
Square Brackets : \[\]
Curly Brackets : \{\}

## Approach & Efficiency
This is Big On

## Solution

![My Groups Whiteboard](assests/Whiteboard-9.png "Whiteboard")        




# Challenge 15
# Challenge Summary
Using a node class, create some trees and work over them. 

## Challenge Description
Create a Node class that has properties for the value stored in the node, the left child node, and the right child node.
Create a BinaryTree class
Define a method for each of the depth first traversals called preOrder, inOrder, and postOrder which returns an array of the values, ordered appropriately.
Any exceptions or errors that come from your code should be semantic, capturable errors. For example, rather than a default error thrown by your language, your code should raise/throw a custom, semantic error that describes what went wrong in calling the methods you wrote for this lab.

Create a BinarySearchTree class
Define a method named add that accepts a value, and adds a new node with that value in the correct location in the binary search tree.
Define a method named contains that accepts a value, and returns a boolean indicating whether or not the value is in the tree at least once.

## Approach
We were provided with the pre-order code. Going from there I created the post and the in order code changing the order the trees searches. 



# Challenge 16
# Challenge Summary
Search a tree for its max value

## Challenge Description
Write an instance method called find-maximum-value. Without utilizing any of the built-in methods available to your language, return the maximum value stored in the tree. You can assume that the values stored in the Binary Tree will be numeric.

## Approach
Our solution is Big O (N) 

![My Groups Whiteboard](assests/whiteboard-10.jpeg "Whiteboard")





# Challenge 17
# Challenge Summary
Search a tree by its breadth and report the value of every node

## Challenge Description
Write a breadth first traversal method which takes a Binary Tree as its unique input. Without utilizing any of the built-in methods available to your language, traverse the input tree using a Breadth-first approach, and return a list of the values in the tree in the order they were encountered.

## Approach


![My Groups Whiteboard](assests/Whiteboard-11.PNG "Whiteboard")



# Challenge 18
# Challenge Summary
Search a tree and return a new tree with the values replaced by fizz, buzz, fizzbuzz depending on if a value is divisible by 3, 5, or both. 

## Challenge Description
Write a function called FizzBuzzTree which takes a k-ary tree as an argument.
Without utilizing any of the built-in methods available to your language, determine whether or not the value of each node is divisible by 3, 5 or both. Create a new tree with the same structure as the original, but the values modified as follows:
If the value is divisible by 3, replace the value with ???Fizz???
If the value is divisible by 5, replace the value with ???Buzz???
If the value is divisible by 3 and 5, replace the value with ???FizzBuzz???
If the value is not divisible by 3 or 5, simply turn the number into a String.
Return a new tree.

## Approach


![My Groups Whiteboard](assests/Whiteboard-12.jpeg "Whiteboard")



# Challenge 26
# Challenge Summary
Write a algorithm that sorts an array using Insertion Sort 

## Challenge Description
Review the pseudocode below, then trace the algorithm by stepping through the process with the provided sample array. Document your explanation by creating a blog article that shows the step-by-step output after each iteration through some sort of visual.

Once you are done with your article, code a working, tested implementation of Insertion Sort based on the pseudocode provided.

## Approach
This sort is Big O(n^2)

![My Groups Whiteboard](assests/Whiteboard-13.jpeg "Whiteboard")



# Challenge 27
# Challenge Summary
Write a algorithm that sorts an array using Merge Sort

## Challenge Description
Review the pseudocode below, then trace the algorithm by stepping through the process with the provided sample array. Document your explanation by creating a blog article that shows the step-by-step output after each iteration through some sort of visual.

Once you are done with your article, code a working, tested implementation of Merge Sort based on the pseudocode provided.

## Approach
This sort is Big O(n log(n))

![My Groups Whiteboard](assests/Whiteboard-14.jpeg "Whiteboard")



# Challenge 28
# Challenge Summary
Write a algorithm that sorts an array using Quick Sort

## Challenge Description
Review the pseudocode below, then trace the algorithm by stepping through the process with the provided sample array. Document your explanation by creating a blog article that shows the step-by-step output after each iteration through some sort of visual.

Once you are done with your article, code a working, tested implementation of Quick Sort based on the pseudocode provided.

## Approach
This sort is Big O(n log(n))

![My Groups Whiteboard](assests/Whiteboard-15.PNG "Whiteboard")




# Challenge 30
# Challenge Summary
Write a Hashtable

## Challenge Description
Implement a Hashtable with the following methods:  

add: takes in both the key and value. This method should hash the key, and add the key and value pair to the table, handling collisions as needed.  
get: takes in the key and returns the value from the table.  
contains: takes in the key and returns a boolean, indicating if the key exists in the table already.  
hash: takes in an arbitrary key and returns an index in the collection.  

## Approach
No Whiteboard for this challenge



# Challenge 31
# Challenge Summary
Write a function that takes a string and returns the first word to be repeated

## Challenge Description
Write a function that accepts a lengthy string parameter.  
Without utilizing any of the built-in library methods available to your language, return the first word to occur more than once in that provided string.  



## Approach
This solution uses Big O(n^2)
![My Groups Whiteboard](assests/Whiteboard-16.jpeg "Whiteboard")



# Challenge 32
# Challenge Summary
Write a function that in binary tree parameters and returns the values found in both trees

## Challenge Description
Write a function called tree_intersection that takes two binary tree parameters.  
Without utilizing any of the built-in library methods available to your language, return a set of values found in both trees.  


## Approach
This solution uses Big O(n log n)
![My Groups Whiteboard](assests/Whiteboard-17.PNG "Whiteboard")




# Challenge 34
# Challenge Summary
Write a function that uses LEFTJOIN to join 2 hashmaps together

## Challenge Description
Write a function that LEFT JOINs two hashmaps into a single data structure.  
The first parameter is a hashmap that has word strings as keys, and a synonym of the key as values.  
The second parameter is a hashmap that has word strings as keys, and antonyms of the key as values.  
Combine the key and corresponding values (if they exist) into a new data structure according to LEFT JOIN logic.  
LEFT JOIN means all the values in the first hashmap are returned, and if values exist in the ???right??? hashmap, they are appended to the   result row. If no values exist in the right hashmap, then some flavor of NULL should be appended to the result row.  
The returned data structure that holds the results is up to you. It doesn???t need to exactly match the output below, so long as it achieves the LEFT JOIN logic.  
Avoid utilizing any of the library methods available to your language.  


## Approach

![My Groups Whiteboard](assests/Whiteboard-18.jpeg "Whiteboard")




# Challenge 35
# Challenge Summary
Implement a graph using Nodes

## Challenge Description
Implement your own Graph. The graph should be represented as an adjacency list, and should include the following methods:  

AddNode()  
Adds a new node to the graph  
Takes in the value of that node  
Returns the added node  
AddEdge()  
Adds a new edge between two nodes in the graph  
Include the ability to have a ???weight???  
Takes in the two nodes to be connected by the edge  
Both nodes should already be in the Graph  
GetNodes()  
Returns all of the nodes in the graph as a collection (set, list, or similar)  
GetNeighbors()  
Returns a collection of edges connected to the given node  
Takes in a given node  
Include the weight of the connection in the returned collection  
Size()  
Returns the total number of nodes in the graph  
Structure and Testing  
Utilize the Single-responsibility principle: any methods you write should be clean, reusable, abstract component parts to the whole challenge. You will be given feedback and marked down if you attempt to define a large, complex algorithm in one function definition.  

Write tests to prove the following functionality:  

Node can be successfully added to the graph  
An edge can be successfully added to the graph  
A collection of all nodes can be properly retrieved from the graph  
All appropriate neighbors can be retrieved from the graph  
Neighbors are returned with the weight between nodes included  
The proper size is returned, representing the number of nodes in the graph  
A graph with only one node and edge can be properly returned  
An empty graph properly returns null  


## Approach

![My Groups Whiteboard](assests/Whiteboard-19.jpeg "Whiteboard")



# Challenge 36
# Challenge Summary
Add a Breadth First search to the graph

## Challenge Description
Extend your graph object with a breadth-first traversal method that accepts a starting node. Without utilizing any of the built-in methods available to your language, return a collection of nodes in the order they were visited. Display the collection.


## Approach

![My Groups Whiteboard](assests/Whiteboard-20.PNG "Whiteboard")



# Challenge 37
# Challenge Summary
Create a method that will take in a graph and return the price of flights to cities from it

## Challenge Description
Write a function based on the specifications above, which takes in a graph, and an array of city names. Without utilizing any of the built-in methods available to your language, return whether the full trip is possible with direct flights, and how much it would cost.



## Approach

![My Groups Whiteboard](assests/Whiteboard-21.PNG "Whiteboard")


# Challenge 38
# Challenge Summary
Do Breadth first transversal on a graph

## Challenge Description
Create a function that accepts an adjacency list as a graph, and conducts a depth first traversal. Without utilizing any of the built-in methods available to your language, return a collection of nodes in their pre-order depth-first traversal order.



## Approach

![My Groups Whiteboard](assests/Whiteboard-22.PNG "Whiteboard")