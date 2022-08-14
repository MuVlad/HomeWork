// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

using System;

class Program
{
    static string IsPalindrome(string numb)
    {
        int length = numb.Length;
        string result = String.Empty;
        for (int i = 0; i < length / 2; i++)
        {
            if (numb[i] != numb[length - i - 1]) result = "Нет";
            else result = "Да";
        }
        return result;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Введите пятизначное число");
        string number = Console.ReadLine();
        Console.WriteLine(IsPalindrome(number));
    }
}