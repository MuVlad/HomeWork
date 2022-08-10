// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите день недели: 1, 2, 3, 4, 5, 6 или 7");
        int dayOfTheWeek = Convert.ToInt32(Console.ReadLine());

        if (dayOfTheWeek == 6 ^ dayOfTheWeek == 7)
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");
        }
    }
}