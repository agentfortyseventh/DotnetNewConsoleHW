// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1
// 7 -> такого числа в массиве нет

Console.Write("Индекс строки: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Индекс столбца: ");
int n = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[7, 7];
Create2DArray(matrix);
Print2DArray(matrix);
if (m < matrix.GetLength(0) && n < matrix.GetLength(1))
{
    Console.Write($"по этому адресу число - {matrix[m, n]}");
}
else
{
    Console.Write($"{m}, {n} - такого адреса не существует");
}
void Create2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}
void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}