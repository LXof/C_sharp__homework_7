// Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
// 8 4 2 4

// 1,1 -> 9
// 1,7 -> элемента с данными индексами в массиве нет

Console.Clear();
Console.WriteLine("Задайте двумерный массив размером m×n:");
Console.Write("m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("\nМассив:");
int[,] array = CreateArray(m, n);
PrintArray(array);

Console.WriteLine("Введите индекс массива:");
Console.Write("i:");
int iValue = Convert.ToInt32(Console.ReadLine());
Console.Write("j:");
int jValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Значение элемента в массиве: {GetValueArray(array, iValue, jValue)}");





int[,] CreateArray(int m, int n)
{
    Random random = new Random();
    int[,] createArray = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            createArray[i, j] = random.Next(1, 10);
        }   
    }
    return createArray;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}  ");
        }   
        Console.WriteLine();
    }
}

string GetValueArray(int[,] arr, int iVal, int jVal)
{
    string arrayValue = "";

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == arr[iVal, jVal])
                arrayValue = Convert.ToString(arr[i, j]);
        }
    }
    return arrayValue;
}