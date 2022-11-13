// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Clear();
Console.WriteLine("Введите число N: ");
int number = int.Parse(Console.ReadLine());
WriteNumber(number, 1);

void WriteNumber(int number, int count)
{
    Console.Write($" " + count);
    if (count < number) WriteNumber(number, count + 1);
}