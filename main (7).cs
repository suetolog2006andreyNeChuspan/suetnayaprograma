

using System;

class TriangleExistence
{
    static void Main()
    {
        Console.WriteLine("Enter the sides of the triangle:");

        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        if (a + b > c && b + c > a && a + c > b)
        {
            Console.WriteLine("The triangle exists.");
        }
        else
        {
            Console.WriteLine("The triangle does not exist.");
        }
    }
}