// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Укажите колличество строк в двумерном массиве: ");
        int amountRows = int.Parse(Console.ReadLine());
        Console.Write("Укажите колличество столбцовв  двумерном массиве: ");
        int amountColumns = int.Parse(Console.ReadLine());
        double[,] array = new double[amountRows, amountColumns];
        Random random = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = Math.Round(random.NextDouble() * 20 - 10, 1);
                Console.Write(array[i, j] + " ");
            }
            System.Console.WriteLine();
        }
    }
}