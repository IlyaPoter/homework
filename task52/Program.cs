// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Clear();
Console.WriteLine("Для формирования массива введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Для формирования массива введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns);
PrintArray(array);
ArifmNumber(array);

int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void ArifmNumber(int[,] arr)
{
    Console.Write($"Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double result = 0;
        int count = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            result = result + arr[i,j];
            count++;
        }
        result = result/count;
        Console.Write($"{result}  ");
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}