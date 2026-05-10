using System;
using System.Collections.Generic;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'. For
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}. Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // PLAN - Step by step:
        // 1. Create a double array with size = 'length'. This array will hold all the multiples.
        // 2. Loop from i = 0 to length - 1. Each loop iteration fills one slot in the array.
        // 3. For each i, calculate the multiple as number * (i + 1).
        // - i=0 gives 1st multiple: number * 1
        // - i=1 gives 2nd multiple: number * 2
        // - etc.
        // 4. Store the calculated value in result[i].
        // 5. Return the filled array.

        // Step 1: Create array of size 'length'
        double[] result = new double[length];

        // Step 2 & 3: Loop and calculate each multiple
        for (int i = 0; i < length; i++)
        {
            // i+1 makes sure we start with 1x, 2x, 3x... not 0x
            result[i] = number * (i + 1);
        }

        // Step 4: Return the array
        return result;
        // TODO Problem 1 End
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'. For example, if the data is
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}. The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // PLAN - Step by step:
        // 1. Use modulo (%) to handle cases where amount > data.Count.
        // Example: rotating a list of 9 items by 12 is the same as rotating by 3.
        // 2. Split the list into 2 parts using GetRange:
        // - rightPart: the last 'amount' elements. These will move to the front.
        // - leftPart: the remaining elements at the front.
        // 3. Clear the original list so we can rebuild it.
        // 4. Add rightPart first, then leftPart using AddRange.
        // This puts the last elements at the front, achieving a right rotation.

        // Step 1: Handle large amount values using modulo
        amount = amount % data.Count;

        // Step 2: Get the last 'amount' elements
        // Start index = data.Count - amount, count = amount
        List<int> rightPart = data.GetRange(data.Count - amount, amount);

        // Step 3: Get the first part of the list
        // Start at index 0, take data.Count - amount elements
        List<int> leftPart = data.GetRange(0, data.Count - amount);

        // Step 4: Clear the original list
        data.Clear();

        // Step 5: Rebuild the list with rightPart first, then leftPart
        data.AddRange(rightPart);
        data.AddRange(leftPart);
        // TODO Problem 2 End
    }
}