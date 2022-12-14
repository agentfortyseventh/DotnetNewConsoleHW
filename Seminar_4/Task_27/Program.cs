// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Console.Write(SumOfNumbers(number));
int SumOfNumbers(int a)
{
    int sum = 0;
    while(a > 0)
    {
        sum = sum + a % 10;
        a = a / 10;
    }
    return sum;
}