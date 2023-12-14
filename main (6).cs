

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите два числа:");

        int num1 = Convert.ToInt32(Console.ReadLine());

        int num2 = Convert.ToInt32(Console.ReadLine());

        int product = num1 * num2;

        if (product > 50)
        {
            Console.WriteLine("Произведение больше 50. Результат после деления на 2 равен: " + (product / 2));
        }
        else
        {
            Console.WriteLine("Произведение не больше 50. Результат после прибавления к нему 25 равен: " + (product + 25));
        }
    }
}
