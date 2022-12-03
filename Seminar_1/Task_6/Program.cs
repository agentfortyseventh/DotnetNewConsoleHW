// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число: ");
string input1 = Console.ReadLine()!;
int A = int.Parse(input1);
if (A % 2 == 0)
{
    Console.Write("чётное число");
}
else
{
    Console.Write("нечётное число");
}