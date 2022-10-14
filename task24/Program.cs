// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();
Console.WriteLine("Введите число А: ");
double numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
double numberB = int.Parse(Console.ReadLine());
double res = Exponentiation(numberA, numberB);
Console.WriteLine(res);

double Exponentiation(double number1, double number2)
{
    double result = Math.Pow(number1, number2);
    return result;
}

