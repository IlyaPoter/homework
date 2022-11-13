// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.Clear();
Console.WriteLine("Введите число M: ");
int numberM = GetNumber();
Console.WriteLine("Введите число N: ");
int numberN = GetNumber();

WriteNumber(numberM, numberN);

int GetNumber()
{
    return int.Parse(Console.ReadLine());
}

void WriteNumber(int numM, int numN)
{
    Console.Write($" " + numM);
    if (numM < numN) WriteNumber(numM+1, numN);
}