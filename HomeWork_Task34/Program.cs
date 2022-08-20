// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Задайте размер массива: ");
        int[] array = new int[Convert.ToInt32(Console.ReadLine())];
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(100, 999);
            if (array[i] % 2 == 0)
            {
                count++;
            }
            Console.Write(array[i] + " ");
        }
        System.Console.Write("-> " + count);

    }
}