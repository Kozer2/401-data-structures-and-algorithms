
# Insertion Sort Blog post

Inserstion sort works by taking the first item in an array and comparing it to the next. If it is greater than that next item, the first one takes its place. If it takes the place of an index that is also smaller than any preceding it, it will sort it into the correct spot.
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

# Merge Sort Blog

Merge sort takes a list and divides it in 2. It then takes those 2 lists and divides them by 2 and so on until it has a list of 1. It then takes that list of 1 and compares it to the next list. It then combines them into one list.
Pseudo Code:

```C#
ALGORITHM Mergesort(arr)
    DECLARE n <-- arr.length
           
    if n > 1
      DECLARE mid <-- n/2
      DECLARE left <-- arr[0...mid]
      DECLARE right <-- arr[mid...n]
      // sort the left side
      Mergesort(left)
      // sort the right side
      Mergesort(right)
      // merge the sorted left and right sides together
      Merge(left, right, arr)

ALGORITHM Merge(left, right, arr)
    DECLARE i <-- 0
    DECLARE j <-- 0
    DECLARE k <-- 0

    while i < left.length && j < right.length
        if left[i] <= right[j]
            arr[k] <-- left[i]
            i <-- i + 1
        else
            arr[k] <-- right[j]
            j <-- j + 1
            
        k <-- k + 1

    if i = left.length
       set remaining entries in arr to remaining values in right
    else
       set remaining entries in arr to remaining values in left

```

We will now look at an example:

1. We start with a list and it is divided at its mid point [8] [4] [23] [42] [15] [16]
2. We now have 2 lists of: [8] [4] [23] and [42] [15] [16]
3. These are divided again.
    1. [8] [4] [23] becomes [8] and [4] [23]. [42] [15] [16] becomes [42] and [15] [16]
    2. Finally we are left with all our seperate lists which then begin to be sorted. 
    3. [8] and [4] are compared and merged. Now they are [4] [8]
    4. [23] is compared with [42] and merged to [23] [42]
    5. [15] and [16] are compared and merged into [15] [16]
    6. [4] [8] and [23] [42] are now merged to [4] [8] [23] [42]
    7. [4] [8] [23] [42] is now compared to [15] [16] and merged to [4] [8] [15] [16] [23] [42]
