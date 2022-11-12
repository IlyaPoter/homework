// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void Main()
{
    Console.Clear();
    Console.WriteLine("Введите количество строк: ");
    int rows = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов: ");
    int columns = int.Parse(Console.ReadLine());
    int[,] array = GetArray(rows, columns, -10, 10);
    PrintArray(array);
    MinSummNumbers(array, rows);
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

void MinSummNumbers(int [,] arr, int row)
{
    int[] arraySumm = new int [row];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int summNumbers = arr[i,0];
        for (int j = 0; j < arr.GetLength(1)-1; j++)
        {
            summNumbers = summNumbers + arr[i,j+1];
        }
        arraySumm[i] =summNumbers;
    }
    int minSummRows = 0;
    for (int k = 0; k < arraySumm.Length-1; k++)
    {
        if(arraySumm[minSummRows]>arraySumm[k+1])
        {
            minSummRows = k+1;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Строка с минимальной суммой чисел: {minSummRows}");
}

void PrintArray(int[,] array)
{
    Console.WriteLine(); //чтобы отделить массив от исходных данных
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Main();