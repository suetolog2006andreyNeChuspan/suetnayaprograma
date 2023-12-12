

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter two numbers:");

        int num1 = Convert.ToInt32(Console.ReadLine());

        int num2 = Convert.ToInt32(Console.ReadLine());

        int product = num1 * num2;

        if (product > 50)
        {
            Console.WriteLine("The product is greater than 50. The result after dividing it by 2 is: " + (product / 2));
        }
        else
        {
            Console.WriteLine("The product is not greater than 50. The result after adding 25 to it is: " + (product + 25));
        }
    }
}