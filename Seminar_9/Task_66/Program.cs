// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine()!);
SumOfElements(m, n, 0);
void SumOfElements (int numberM, int numberN, int sum)
{
    if (numberM > numberN)
    {
        Console.WriteLine($"Сумма элементов в промежутке от M до N: {sum}");
        return;
    }
    sum += (numberM++);
    SumOfElements(numberM, numberN, sum);
}