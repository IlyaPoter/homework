// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void Main()
{
    Console.Clear();
    int[,,] array = new int[2, 2, 2];
    int[,,] resultArray = GetArray(array);
    PrintArray(resultArray);
}

int[,,] GetArray(int[,,] arr)
{
    int count = 99;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int z = 0; z < arr.GetLength(2); z++)
            {
                arr[i, j, z] = count;
                count--;
            }
        }
    }
    return arr;
}

void PrintArray(int[,,] array)
{
    Console.WriteLine(); //чтобы отделить массив от исходных данных
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                Console.Write($"{array[i, j, z]} ({i},{j},{z})  ");
            }
            Console.WriteLine();
        }

    }
}

Main();