// Задача 64: Задайте значение N. Напишите программу, которая выведет все чётные
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "4, 2"
// N = 8 -> "8, 6, 4, 2,"

void Main()
{
    Console.Clear();
    Console.WriteLine("Введите значение N: ");
    int number = GetNumber();
    int count = 2;
    EvenNumber(number);
}

int GetNumber()
{
    return int.Parse(Console.ReadLine());
}

void EvenNumber(int num)
{
    if (num >1 && num%2==0)
    {
        Console.Write(num + $" ");
    }
    EvenNumber(num-1);
}

Main();