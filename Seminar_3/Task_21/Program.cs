// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите X координату первой точки: ");
int X1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите Y координату первой точки: ");
int Y1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите Z координату первой точки: ");
int Z1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите X координату второй точки: ");
int X2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите Y координату второй точки: ");
int Y2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите Z координату второй точки: ");
int Z2 = int.Parse(Console.ReadLine()!);
Console.Write(Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2) + Math.Pow(Z1 - Z2, 2)));