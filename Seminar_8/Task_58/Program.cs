// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] firstMatrix = new int[5, 5];
Create2DArray(firstMatrix);
Print2DArray(firstMatrix);
Console.WriteLine();
int[,] secondMatrix = new int[5, 5];
Create2DArray(secondMatrix);
Print2DArray(secondMatrix);
Console.WriteLine();
int[,] resultMatrix = new int[5, 5];
MultiplyMatrix(firstMatrix, secondMatrix, resultMatrix);
Print2DArray(resultMatrix);
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
void MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int c = 0; c < firstMatrix.GetLength(1); c++)
            {
                sum += firstMatrix[i, c] * secondMatrix[c, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}