// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число: ");
        string numb = Console.ReadLine();
        if (numb.Length < 3)
        {
            Console.WriteLine("Третьей цифры нет");
        }
        else
            Console.WriteLine(numb[2]);
    }
}