// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите трехзначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        number = number / 10;
        number = number % 10;
        Console.Write("Вторая цифра этого числа: ");
        Console.WriteLine(number);
    }
}