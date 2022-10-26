Console.Clear();
int[] GetArray(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(100, 1000);
        Console.Write($"{res[i]} ");

    }
    return res;
}

int Numbers(int[] array)
{
    int count = 0;
    foreach (int element in array)
    {
        if (element % 2 == 0)
        count += 1;
    }
    return count;

}

int[] array = GetArray(4);
int result = Numbers(array);
Console.WriteLine();
Console.WriteLine($"Количество четных числе = {result}");