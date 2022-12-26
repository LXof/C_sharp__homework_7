// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Console.WriteLine("Задайте двумерный массив размером m×n:");
Console.Write("m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("\nМассив:");
int[,] array = CreateArray(m, n);
PrintArray(array);


Console.WriteLine($"Столбцов в массиве: {array.GetLength(1)}");
Console.WriteLine("Среднее арифметическое каждого столбца:");
GetAvgColumn(array, m);





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

void GetAvgColumn(int[,] arr, int amound)
{
    double sum = 0;

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum = sum + arr[i, j];
        }
        Console.WriteLine($"{Math.Round(sum / amound, 2)}"); 
    }
}