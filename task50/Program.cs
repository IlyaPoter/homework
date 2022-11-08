// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет ([1,7] это позиция элемента)

Console.Clear();
Console.WriteLine("Для формирования массива введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Для формирования массива введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер строки: ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int column = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns);
PrintArray(array);
PositionNumber(row, column, array);

void PositionNumber(int row, int column, int[,] arr)
{
    if (row > arr.GetLength(0) || column > arr.GetLength(1))
    {
        Console.WriteLine($"В массиве элемент ({row}, {column}) отсутствует");
    }
    else
    {
        Console.WriteLine($"На позиции ({row}, {column}) находится элемент {arr[row, column]}");
    }
}




int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(-10, 10);
        }
    }
    return array;
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