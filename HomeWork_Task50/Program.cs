// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = {{1, 2, 3, 4},
                        {5, 6, 7, 8},
                        {9, 10, 11, 12}};
        Console.WriteLine("Введите номер строки интересующего вас элемента массива: ");
        int row = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите номер столбца интересующего вас элемента массива: ");
        int column = int.Parse(Console.ReadLine());

        if ((row < array.GetLength(0) && row >= 0) && (column < array.GetLength(1) && column >= 0))
        {
            foreach (int number in array)
            {
                if (number == array[row, column]) Console.WriteLine(array[row, column]);

            }
        }
        else System.Console.WriteLine("Элемента на данных позиций нет");
    }
}
