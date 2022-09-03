// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18 
using System;
class Program
{
    static int[,] productMatrix(int[,] firstMatrix, int[,] secondMatrix)
    {
        int[,] resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];

        for (int i = 0; i < resultMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < resultMatrix.GetLength(1); j++)
            {
                int sum = 0;
                for (int k = 0; k < resultMatrix.GetLength(1); k++)
                {
                    sum += firstMatrix[i, k] * secondMatrix[k, j];
                }
                resultMatrix[i, j] = sum;
            }
        }
        return resultMatrix;
    }
    static void printMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    static void Main(string[] args)
    {
        int[,] firstMatrix = {{2,4},
                              {3,2}};
        int[,] secondMatrix = {{3,4},
                               {3,3}};
        printMatrix(productMatrix(firstMatrix, secondMatrix));
    }
}