

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите первое целое число:");

        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите второе целое число:");

        int num2 = Convert.ToInt32(Console.ReadLine());

        int sum = num1 + num2;

        Console.WriteLine("Сумма двух чисел равна: " + sum);
    }
}