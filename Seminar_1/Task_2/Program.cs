// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
// a = 2; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3

Console.Write("Введите первое число: ");
string input1 = Console.ReadLine()!;
Console.Write("Введите второе число: ");
string input2 = Console.ReadLine()!;
int A = int.Parse(input1);
int B = int.Parse(input2);
if (A < B)
{
    Console.Write("Результат: ");
    Console.Write(B);
    Console.Write(" > ");
    Console.Write(A);
}
else if (A > B)
{
    Console.Write("Результат: ");
    Console.Write(A);
    Console.Write(" > ");
    Console.Write(B);
}
else if (A == B)
{
    Console.Write("Результат: ");
    Console.Write(A);
    Console.Write(" = ");
    Console.Write(B);
}