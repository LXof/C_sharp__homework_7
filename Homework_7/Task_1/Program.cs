﻿// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9


Console.Clear();
Console.WriteLine("Задайте двумерный массив размером m×n:");
Console.Write("m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = CreateArray(m, n);
PrintArray(array);

double[,] CreateArray(int m, int n)
{
    Random random = new Random();
    double[,] createArray = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            createArray[i, j] = random.NextDouble() * 10;
        }   
    }
    return createArray;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(arr[i, j], 2)} ");
        }   
        Console.WriteLine();
    }
}