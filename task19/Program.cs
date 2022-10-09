Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
if (number / 10000 > 9 | number / 10000 < 1)
{
    Console.WriteLine("Вы ввели не пятизначное число. Повторите попытку");
}
int numberOne = number / 10000;
int numberTwo = (number / 1000) % 10;
int numberFour = (number % 100) / 10;
int numberFive = number % 10;
if (numberOne == numberFive && numberTwo == numberFour)
{
    Console.WriteLine($"Число {number} полиндром");
}
else
{
    Console.WriteLine($"Число {number} не является полиндромом");
}