// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

void Main()
{
    Console.Clear();
    Console.WriteLine("Введите неотрицательное число m: ");
    int numberM = GetNumber();
    Console.WriteLine("Введите неотрицательное число m: ");
    int numberN = GetNumber();

    int result = AkkNumbers(numberM, numberN);
    Console.WriteLine(result);
}

int AkkNumbers(int numM, int numN)
{
    if (numM == 0) return numN + 1;
    else
    {
        if (numM != 0 && numN == 0) return AkkNumbers(numM - 1, 1);
        else
        {
            return AkkNumbers((numM - 1), AkkNumbers(numM, numN - 1));
        }
    }
}

int GetNumber()
{
    return int.Parse(Console.ReadLine());
}

Main();