// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Clear();
Console.WriteLine("Введите число A: ");
int numberA = GetNumber();
Console.WriteLine("Введите число B: ");
int numberB = GetNumber();

int res = 1;
int result = MultiplyNumber(numberA, numberB, res);
Console.WriteLine(result);

int GetNumber()
{
    return int.Parse(Console.ReadLine());
}

int MultiplyNumber(int numA, int numB, int res)
{
    res = res * numA;
    if (numB > 1)
    {
        return MultiplyNumber(numA, numB-1, res);
    }
    else
    {
        return res;
    }
}