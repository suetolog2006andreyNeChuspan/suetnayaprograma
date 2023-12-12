

// Import necessary libraries
using System;

// Create a class named "Program"
class Program
{
    // Main method
    static void Main(string[] args)
    {
        // Prompt user to enter first integer
        Console.WriteLine("Enter the first integer: ");

        // Read user input and convert it to integer
        int num1 = Convert.ToInt32(Console.ReadLine());

        // Prompt user to enter second integer
        Console.WriteLine("Enter the second integer: ");

        // Read user input and convert it to integer
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Calculate the sum of the two integers
        int sum = num1 + num2;

        // Display the result to the user
        Console.WriteLine("The sum of {0} and {1} is {2}.", num1, num2, sum);
    }
}