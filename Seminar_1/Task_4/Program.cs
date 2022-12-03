// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.Write("Введите первое число: ");
string input1 = Console.ReadLine()!;
Console.Write("Введите второе число: ");
string input2 = Console.ReadLine()!;
Console.Write("Введите третье число: ");
string input3 = Console.ReadLine()!;
int A = int.Parse(input1);
int B = int.Parse(input2);
int C = int.Parse(input3);
int max = A;
if (B > A) max = B;
if (C > max) max = C;
{
    Console.Write("Результат: ");
    Console.Write(max);
}