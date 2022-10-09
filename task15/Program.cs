Console.Clear();
Console.WriteLine("Введите цифру дня недели: ");
int numberWeek = int.Parse(Console.ReadLine());
if (numberWeek < 1 | numberWeek > 7)
{
    Console.WriteLine("Такого дня недели не существует. Введите число в диапазоне от 1 до 7");
}
else if (numberWeek == 6 | numberWeek == 7)
{
    Console.WriteLine("Указанный день - выходной");
}
else
{
    Console.WriteLine("Указанный день не является выходным");
}

if (numberWeek==null)
{
    Console.WriteLine("Пустой ввод");
}
