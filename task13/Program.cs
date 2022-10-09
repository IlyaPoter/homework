// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number < 0)
{
    number = number * -1;
}
if (number / 100 < 1)
{
    Console.WriteLine("Во введенном числе третьей цифры нет");
}
else
{
    int result = number % 10;
    Console.WriteLine(result);
}