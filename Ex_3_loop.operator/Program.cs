using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть число для таблиці множення: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine($"Таблиця множення для {number}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} * {i} = {number * i}");
        }
    }
}

