// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()); Console.Clear();
int sum = 0;
int result = SumNumber(number, sum);
Console.WriteLine(result);
int SumNumber(int num, int sum)
{
    sum = sum + num % 10;
    if (num > 0)
    {
        return SumNumber(num / 10, sum);
    }
    else
    {
        return sum;
    }
}