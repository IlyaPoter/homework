// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
//  01 02 03 04
//  12 13 14 05
//  11 16 15 06
//  10 09 08 07
void Main()
{
    Console.Clear();
    int[,] array = GetArray();
    PrintArray(array);
}

int[,] GetArray()
{
    int[,] array = new int[4, 4];
    int count = 0;
    for (int j = 0; j < 3; j++)
    {
        count++;
        array[0, j] = count;
    }
    for (int i = 0; i < 4; i++)
    {
        count++;
        array[i, 3] = count;
    }
    for (int k = 3; k > 0; k--)
    {
        array[3, k] = count;
        count++;
    }
    for (int l = 3; l > 1; l--)
    {
        array[l, 0] = count;
        count++;
    }
    for (int z = 0; z < 3; z++)
    {
        array[1, z] = count;
        count++;
    }
    for (int m = 2; m > 0; m--)
    {
        array[2, m] = count;
        count++;
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
Main();