// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
//Вводим координаты X, Y, Z первой точки
Console.WriteLine("Введите значение координаты X первой точки: ");
int oneX = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение координаты Y первой точки: ");
int oneY = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение координаты Z первой точки: ");
int oneZ = int.Parse(Console.ReadLine());

//Вводим координаты X, Y, Z второй точки
Console.WriteLine("Введите значение координаты X второй точки: ");
int twoX = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение координаты Y второй точки: ");
int twoY = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение координаты Z второй точки: ");
int twoZ = int.Parse(Console.ReadLine());

double result = Math.Round((Math.Sqrt(Math.Pow((twoX - oneX), 2) + Math.Pow((twoY - oneY), 2) + Math.Pow((twoZ - oneZ), 2))), 2);
Console.WriteLine($"Расстояние между точками {result}");

