// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

using System;

class Program
{
    static int Exponentiation(int a, int b)
    {
        int result = a;
        for (int i = 1; i < b; i++)
        {
            result *= a;
        }
        return result;
    }
    static void Main(string[] args)
    {
        Console.Write("Введите первое число: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        Console.Write($"{number1} в степени {number2} = {Exponentiation(number1, number2)}");

    }
}