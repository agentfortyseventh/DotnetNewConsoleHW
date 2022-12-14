// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
// 3,5 -> 243 (3⁵)
// 2,4 -> 16

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Console.Write("Введите степень: ");
int degree = int.Parse(Console.ReadLine()!);
Console.Write(Power(number, degree));
int Power(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result = result * a;
    }
    return result;
}