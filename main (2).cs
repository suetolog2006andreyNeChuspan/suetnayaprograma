

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое целое число:");

        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите второе целое число:");

        int num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine("Большее число: " + num1);
        }
        else
        {
            Console.WriteLine("Большее число: " + num2);
        }
    }
}