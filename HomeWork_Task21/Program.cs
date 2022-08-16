// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

using System;

class Program
{
    static double DistanceSearch(int[] a, int[] b)
    {
        double distance = Convert.ToDouble(Math.Sqrt(Math.Pow((b[0] - a[0]), 2) + Math.Pow((b[1] - a[1]), 2) + Math.Pow((b[2] - a[2]), 2)));
        return distance;
    }
    static int[] InputPoint()
    {

        int[] point = new int[3];
        Console.Write("Введите координаты точки на оси X: ");
        point[0] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите координаты точки на оси Y: ");
        point[1] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите координаты точки на оси Z: ");
        point[2] = Convert.ToInt32(Console.ReadLine());
        return point;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Введите координаты точки A");
        int[] firstPoint = InputPoint();
        Console.WriteLine("Введите координаты точки B");
        int[] secondPoint = InputPoint();

        Console.Write("Растояние между ними = ");
        Console.WriteLine(Math.Round(DistanceSearch(firstPoint, secondPoint), 2));
    }
}