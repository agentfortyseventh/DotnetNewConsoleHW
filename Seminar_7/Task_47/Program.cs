// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
// m = 3, n = 4
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Кол-во строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Кол-во столбцов: ");
int n = int.Parse(Console.ReadLine()!);
double[,] matrix = Create2DArray(m, n, -10, 10);
Print2DArray(matrix);
double[,] Create2DArray(int m, int n, int minValue, int maxValue)
{
    double[,] matrix = new double[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round((maxValue - minValue) * new Random().NextDouble() + minValue, 2);
        }
    }
    return matrix;
}
void Print2DArray(double[,] matrix)
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