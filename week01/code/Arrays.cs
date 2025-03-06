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

        // PLAN 
        // First, I will create an array of the specified 'length'
        // Second, make a for loop that fills the array with multiples of the specified 'number'
        // Then, when returning the result, I will multiply the 'number' with '(i + 1)' 
        // to make sure we get the multiples starting from the specified 'number'


        // We use this line to create an array of the specified length
        double[] result = new double[length];

        // This for loop fills the array with multiples of the specified number
        // '(i + 1)' this code ensures we get the multiples starting from the specified number
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1); 
        }

        return result;
        //return []; // replace this return statement with your own

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

        // PLAN
        // I first have to ensure the 'amount' is within the range
        // Then, I will calculate the number of shifts
        // I have to create a function called 'ReverseList' to reverse the list or a portion of it
        // Then, I will reverse the whole list using the function 'ReverseList'
        // Finally, I will reverse the first and second part of the list using the function 'ReverseList' 

        int count = data.Count;
        
        // First, we make sure the amount is within a valid range (1 to data.Count)
        if (count == 0 || amount <= 0 || amount >= count)
            return;
        
        // Next, we calculate the number of shifts (in case the amount > count)
        amount = amount % count;

        // Next, we reverse the whole list
        ReverseList(data, 0, count - 1);

        // Next, we reverse the first part of the list (from 0 to amount-1)
        ReverseList(data, 0, amount - 1);

        // Finally, we reverse the second part of the list (from amount to count-1)
        ReverseList(data, amount, count - 1);

    }

    // I use this function to reverse the list
    private static void ReverseList(List<int> data, int start, int end)
    {
        while (start < end)
        {
            int temp = data[start];
            data[start] = data[end];
            data[end] = temp;
            start++;
            end--;
        }
    }

}
