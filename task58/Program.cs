// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить
// произведение двух матриц.(посмотрите как реализуется произведение матриц, там не просто перемножение элемент на элемент)
// Например, даны 2 матрицы:
//  2 4 | 3 4
//  3 2 | 3 3
// Результирующая матрица будет:
//  18 20
//  15 18
void Main()
{

    Console.Clear();
    Console.WriteLine("Введите количество строк матрицы 1: ");
    int rows1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов матрицы 1: ");
    int columns1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите количество строк матрицы 2: ");
    int rows2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов матрицы 2: ");
    int columns2 = int.Parse(Console.ReadLine());
    if (columns1 != rows2)
    {
        Console.WriteLine("Умножение матриц невозможно. Число столбцов матрицы 1 не равно числу строк матрицы 2");
    }
    else
    {
        int[,] array1 = GetArray(rows1, columns1, 1, 10);
        Console.Write("Массив 1:");
        PrintArray(array1);
        Console.WriteLine();
        int[,] array2 = GetArray(rows2, columns2, 1, 10);
        Console.Write("Массив 2:");
        PrintArray(array2);

        int[,] multiArray = MultiplyArrays(array1, array2);
        Console.WriteLine();
        Console.Write("Результат произведения матриц:");
        PrintArray(multiArray);
    }
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

int[,] MultiplyArrays(int[,] arr1, int[,] arr2)
{
    int[,] multiArray = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                multiArray[i, j] = multiArray[i, j] + arr1[i, k] * arr2[k, j];
            }
        }
    }
    return multiArray;
}

Main();