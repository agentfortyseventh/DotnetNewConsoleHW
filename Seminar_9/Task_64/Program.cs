// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
PrintNumbersFromNTo1(number);
void PrintNumbersFromNTo1 (int number)
{
    if (number <= 0) return;
    Console.Write(number + " ");
    PrintNumbersFromNTo1 (number - 1);
}