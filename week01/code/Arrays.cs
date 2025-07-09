public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Step 1: Create an array of type double with the size given by 'length'.
        // Step 2: Use a loop (for example, a for loop) to fill the array.
        // Step 3: At each position in the array, store the corresponding multiple of 'number'.
        //         For example, at index 0 store number * 1, at index 1 store number * 2, and so on.
        // Step 4: Return the complete array containing the generated multiples.

            double[] multiples = new double[length];

            for (int i = 0; i < length; i++)
            {
                multiples[i] = number * (i + 1);
            }

        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1: Get the last 'amount' elements of the list using GetRange.
        // Step 2: Get the rest of the elements from the beginning up to data.Count - amount.
        // Step 3: Clear the original list (or remove all elements).
        // Step 4: Add the elements from step 1 to the now-empty list.
        // Step 5: Add the elements from step 2 after that to complete the rotation.

        List<int> rightPart = data.GetRange(data.Count - amount, amount);
        List<int> leftPart = data.GetRange(0, data.Count - amount);

        data.Clear();
        data.AddRange(rightPart);
        data.AddRange(leftPart);

    }
}
