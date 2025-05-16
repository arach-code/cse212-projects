using System;
using System.Collections.Generic;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  
    /// For example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.
    /// Assume that length is a positive integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Step 1: Create an array of type double with size equal to 'length'.
        double[] multiples = new double[length];

        // Step 2: Use a for loop to populate each element in the array.
        // Each element at index i should be (i + 1) * number.
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        // Step 3: Return the filled array.
        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  
    /// For example, if the data is List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and amount is 3, 
    /// the result should be List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.
    ///
    /// The function modifies the list in place using slicing and range methods.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1: Determine how many elements are in the list
        int count = data.Count;

        // Step 2: Use GetRange to get the last 'amount' elements (these will be moved to the front)
        List<int> lastPart = data.GetRange(count - amount, amount);

        // Step 3: Remove those elements from the end of the original list
        data.RemoveRange(count - amount, amount);

        // Step 4: Insert the lastPart at the beginning of the list using InsertRange
        data.InsertRange(0, lastPart);
    }
}
