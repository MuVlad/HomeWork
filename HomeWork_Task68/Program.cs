// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

using System;

class Program
{
    static int functionAckerman(int m, int n)
    {
        if (m == 0) return n + 1;
        if ((n == 0 && m > 0)) return functionAckerman(m - 1, 1);
        else return functionAckerman(m - 1, functionAckerman(m, n - 1));
    }
    static void Main(string[] args)
    {
        Console.Write("Введите число M: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Введите число N: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(functionAckerman(n, m));
    }
}