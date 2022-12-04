// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine()!);
int result = (number % 100) / 10;
if ((number / 100 > 0) && (number / 1000 == 0))
{
    Console.Write($"Результат: {result}");
}
else
{
    Console.Write($"Введено не трёхзначное число: {number}");
}