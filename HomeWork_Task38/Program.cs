// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Задайте массив звполнив его вещественными числами через пробел");
        string numbers = Console.ReadLine();
        string[] arrayString = numbers.Split(" ");
        double[] arrayDouble = new double[arrayString.Length];
        double min = Double.MaxValue;
        double max = arrayDouble[0];
        for (int i = 0; i < arrayString.Length; i++)
        {
            arrayDouble[i] = Convert.ToDouble(arrayString[i]);

            if (arrayDouble[i] < min)
            {
                min = arrayDouble[i];
            }
            else if (arrayDouble[i] > max)
            {
                max = arrayDouble[i];
            }
        }

        Console.WriteLine($"Разница между максимальным[{max}] и минимальным[{min}] элементами масива = {max - min}");

    }
}