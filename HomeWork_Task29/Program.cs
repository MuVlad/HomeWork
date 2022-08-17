// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

using System;

class Program
{
    static void ShowArray(int[] ar)
    {
        for (int i = 0; i < ar.Length; i++)
        {
            Console.WriteLine($"array[{i}] = {ar[i]}");
        }
    }
    static int[] CreaterArray(){
        Console.Write("Задайте размер массива: ");
        int length = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[length];
        for (int i = 0; i < length; i++)
        {
            Console.Write($"Введите элемент под индексом {i} : ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        return array;
    }
    static void Main(string[] args)
    {
        ShowArray(CreaterArray());
    }
}