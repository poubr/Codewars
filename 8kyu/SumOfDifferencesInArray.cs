/*
DESCRIPTION:

Your task is to sum the differences between consecutive pairs in the array in descending order.

Example

[2, 1, 10]  -->  9
In descending order: [10, 2, 1]

Sum: (10 - 2) + (2 - 1) = 8 + 1 = 9

If the array is empty or the array has only one element the result should be 0 (Nothing in Haskell, None in Rust).
*/

using System;

public static class Kata
{
    public static int SumOfDifferences(int[] arr)
    { 
        int result = 0;
        Array.Sort(arr);
        if (arr.Length > 1)
        {
            int counter = 0;
            while (counter < arr.Length - 1)
            {
                result += Math.Abs((arr[counter] - arr[counter + 1]));
                counter ++;
            }
        }
        return result;
    } 
}