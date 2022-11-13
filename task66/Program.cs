// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.WriteLine("Введите значение M: ");
int numberM = GetNumber();
Console.WriteLine("Введите значение N: ");
int numberN = GetNumber();
int summNumbers = 0;
int result = SummNumber(numberM, numberN, summNumbers);
Console.WriteLine(result);
int SummNumber(int numM, int numN, int summ)
{
    if (numM <= numN)
    {
        summ = summ + numM;
        return SummNumber(numM + 1, numN, summ);
    }
    return summ;
}

int GetNumber()
{
    return int.Parse(Console.ReadLine());
}

