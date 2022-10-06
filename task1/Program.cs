
Console.WriteLine("Введите первое число: ");
int numberOne = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberTwo = int.Parse(Console.ReadLine());
if (numberOne>numberTwo)
{
    Console.WriteLine("Максимальное число первое: "+numberOne );
}
else
{
    Console.WriteLine("Максимальное число второе: "+numberTwo );
}
if (numberOne==numberTwo)
{
    Console.WriteLine("Числа равны: "+numberOne+" = "+numberTwo);
}