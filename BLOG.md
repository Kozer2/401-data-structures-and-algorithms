
# Insertion Sort Blog post

Insertion sort works by taking the first item in an array and comparing it to the next. If it is greater than that next item, the first one takes its place. If it takes the place of an index that is also smaller than any preceding it, it will sort it into the correct spot.
It is not the most efficient way to sort an array. Its time complexity is O(n^2)

Example: We have a list of un-sorted numbers

1. [8] [4] [23] [42] [15] [16]
2. It compares the first index to the next
    1. [8] --> [4] = [4] [8]
3. It then continues to the next index
    1. [4] [8] --> [23]
    2. [4] [8] [23] --> [42]
    3. [4] [8] [23] [42] --> [15]
        1. Finding a new smaller number it sorts it
        2. [4] [8] [23] --> [15] [42]
        3. [4] [8] [15] [23] [42]
    4. [4] [8] [15] [23] [42] --> [16]
    5. [4] [8] [15] [23] --> [16] [42]
    6. [4] [8] [15] --> [16] [23] [42]
