// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = {
                        {1, 4, 7, 2},
                        {5, 9, 2, 3},
                        {8, 4, 2, 4}
        };
        double average = 0;
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(0); j++)
            {
                average += array[j, i];
            }
            Console.WriteLine(average / array.GetLength(0) + " ");
            average = 0;

        }
    }
}