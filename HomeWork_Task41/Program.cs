// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите числа чрез пробел: ");
        string numbers = Console.ReadLine();
        string[] array = numbers.Split(" ");
        int[] arrayInt = new int[array.Length];
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            arrayInt[i] = int.Parse(array[i]);
            if (arrayInt[i]  > 0) count++;       
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine($"-> {count}");
    }
}