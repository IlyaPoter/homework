// // Задача 41. Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввел пользователь

void Main()
{
    Console.Clear();
    int[] array = GetNumber();
    int result = TestNumber(array);
    Console.WriteLine($"Количество введенных чисел больше нуля: {result}");
}

int[] GetNumber()
{
    Console.Write("Введите числа через пробел: ");
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    return arr;
}

int TestNumber(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Main();