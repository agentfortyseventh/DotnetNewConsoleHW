﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
string input1 = Console.ReadLine()!;
int N = int.Parse(input1);
for (int i = 1; i <= N; i++)
    if(i % 2 == 0)
    {
        Console.Write(i);
        Console.Write(" ");
    }