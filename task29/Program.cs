Console.Clear();
int[] GetArray(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(0,100);
        Console.Write($"{res[i]} ");

    }
    return res;
}

int SumNumbers(int[] array)
{
    int sum = 0;
    for (int i=0;i<array.Length;i=i+2)
    {
        sum += array[i];
    }
    return sum;
}

int[] array = GetArray(5);
int result = SumNumbers(array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {result}");
