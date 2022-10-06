
Console.WriteLine("Введите первое число: ");
int numberOne = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberTwo = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int numberThree = int.Parse(Console.ReadLine());
int max = numberOne;
if (numberTwo>max)
{
    max=numberTwo;
}
if (numberThree>max)
{
    max=numberThree;
}
Console.WriteLine("Максимальное число: "+max);
