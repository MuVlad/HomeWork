// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

using System;

class Pogram
{
    static int SumOfDigits(int numb)
    {
        int result = 0;
        while (numb > 0)
        {
            result += numb % 10;
            numb /= 10;
        }
        return result;
    }
    static void Main(string[] args)
    {
        Console.Write("Введите чило: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Сумма цифер числа {number} = {SumOfDigits(number)}");
    }
}