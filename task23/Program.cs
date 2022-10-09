// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int count = 1;
double result = 0;
if (number < 0)
{
    Console.WriteLine("Вы ввели отрицательное значение. Повторите попытку");
}
Console.WriteLine($"Кубы чисел от 1 до {number}:");
while (count<number | count==number)
{
    result = Math.Pow(count,3);
    Console.WriteLine(result);
    count++;
}