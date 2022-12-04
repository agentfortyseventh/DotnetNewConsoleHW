// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число (1-7): ");
int number = int.Parse(Console.ReadLine()!);
if ((number >= 1) && (number <= 5))
{
    Console.Write("Будний день");
}
else if ((number >= 6) && (number <= 7))
{
    Console.Write("Выходной");
}
else
{
    Console.Write("Недопустимое значение");
}