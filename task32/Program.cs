// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Main()
{
    Console.Clear();
    Console.WriteLine("Введите b1: ");
    int b1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите k1: ");
    int k1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите b2: ");
    int b2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите k2: ");
    int k2 = int.Parse(Console.ReadLine());
    double x = TestX(b1, k1, b2, k2);
    double y = TestY(b1, k1, b2, k2);
    Console.WriteLine($"Две прямые пересекаются в точке ({x}, {y})");
}

double TestX(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double TestY(double b1, double k1, double b2, double k2)
{
    double y = k1 * ((b2 - b1) / (k1 - k2)) + b1;
    return y;
}
Main();