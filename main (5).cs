

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество Кбайт:");

        string input = Console.ReadLine();

        int kilobytes = Convert.ToInt32(input);

        int bits = kilobytes * 8;

        Console.WriteLine("В " + kilobytes + " Кбайт содержится " + bits + " бит.");

        Console.ReadLine();
    }
}