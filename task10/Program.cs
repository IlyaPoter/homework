// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.WriteLine("Введите трёхзначное число : ");
int number = int.Parse(Console.ReadLine());
if (number/100 < 1 | number/100 >9)
{
    Console.WriteLine("Вы ввели не трёхзначное число, повторите попытку");
}
else
{
    int result = (number/10)%10;
    Console.WriteLine($"Вторая цифра числа {number} - {result}");
}
