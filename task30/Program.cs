Console.Clear();
int[] GetArray(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(0, 100);
        Console.Write($"{res[i]} ");

    }
    return res;
}

int ResNumbers(int[] array)
{
    int maxNumber = array[0];
    int minNumber = array[0];
    foreach (int element in array)
    {
        if (element > maxNumber)
            maxNumber = element;
        else if (element < minNumber)
            minNumber = element;
    }
    int result = maxNumber - minNumber;
    return result;
}

int[] array = GetArray(5);
int difNumber = ResNumbers(array);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным числом {difNumber}");
