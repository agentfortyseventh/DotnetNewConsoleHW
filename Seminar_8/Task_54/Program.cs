// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] matrix = new int[5, 5];
Create2DArray(matrix);
Print2DArray(matrix);
SortingFromMore(matrix);
Console.WriteLine();
Print2DArray(matrix);
void Create2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}
void SortingFromMore(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int c = 0; c < matrix.GetLength(1) - 1; c++)
            {
                if (matrix[i, c] < matrix[i, c + 1])
                {
                    int number = matrix[i, c + 1];
                    matrix[i, c + 1] = matrix[i, c];
                    matrix[i, c] = number;
                }
            }
        }
    }
}
void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}