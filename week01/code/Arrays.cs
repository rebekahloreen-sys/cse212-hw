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
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.



        // Creating an array to put the multiples into
        // I first put this inside the loop, then realized I needed to put it first.
        double[] multiples = new double[length];


        // Creating a for loop, with the length required
        for (int i = 0; i < length; i++)
        {
            // Multiplying number times i+1 to get the multiple right
            multiples[i] = number * (i + 1);

        }
        // returning the array
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
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Figured making a new list would be easier than ohter methods that I couldnt't think of.
        // New list for rotated numbers
        List<int> newList = new List<int>();    

        // I need to add the amount from the last end of the old list to the new list
        for (int i = data.Count - amount; i < data.Count; i++)
        {
            newList.Add(data[i]); 
        }
        // Adding the rest.
        for (int i = 0; i < data.Count - amount; i++)
        {
            newList.Add(data[i]);
        }
        // Clearing the old list.
        data.Clear();
        // Adding the old list to the new list.
        for (int i = 0; i < newList.Count; i++)
        {
            data.Add(newList[i]);
        } 
        
    }
}
