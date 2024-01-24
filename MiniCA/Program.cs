using System;  // Import the System namespace to use built-in data types and functions.
using System.Collections.Generic;  // Import the System.Collections.Generic namespace to use generic collection classes.

class Program  // Define a class named Program.
{
    static List<int> TwoSum(int[] nums, int target)  // Define a static method named TwoSum that takes an integer array and a target integer, and returns an integer list.
    {
        Dictionary<int, int> numDict = new Dictionary<int, int>();  // Define a dictionary numDict to store numbers from the array and their indices.
        for (int i = 0; i < nums.Length; i++)  // Iterate through each number in the array.
        {
            int complement = target - nums[i];  // Calculate the difference between the current number and the target value.
            if (numDict.ContainsKey(complement))  // If the dictionary already contains the key corresponding to this difference.
            {
                return new List<int>() { numDict[complement], i };  // Return a list containing the index corresponding to this difference and the current index.
            }
            numDict[nums[i]] = i;  // Add the current number and its index to the dictionary.
        }
        return null;  // If no two numbers are found whose sum equals the target, return null.
    }

    static void Main(string[] args)  // Define the main method of the program.
    {
        int[] nums = { 2, 7, 11, 15 };  // Define an integer array.
        int target = 9;  // Define a target integer.
        List<int> result = TwoSum(nums, target);  // Call the TwoSum method and store the result in the result variable.
        if (result != null)  // If the result is not null.
        {
            Console.WriteLine($"Indices: {result[0]} and {result[1]}");  // Output the indices of the two numbers.
        }
        else
        {
            Console.WriteLine("No two sum solution found.");  // Output a message indicating that no two numbers sum to the target.
        }
    }
}
//We're using a dictionary to keep track of the numbers we've seen so far.
//For each number, we check if its complement (the difference between the target and the current number) is in the dictionary.
//If it is, we've found our two numbers, and we return their indices. If not, we add the current number to the dictionary.
//If we make it through the entire array without finding our two numbers, we return null.