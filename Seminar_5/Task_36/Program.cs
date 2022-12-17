// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях
// Размер массива, минимальное значение и максимальное значение вводим через консоль
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите размер массива: ");
int SizeArray = int.Parse(Console.ReadLine()!);
Console.Write("Диапазон от: ");
int MinBorder = int.Parse(Console.ReadLine()!);
Console.Write("Диапазон до: ");
int MaxBorder = int.Parse(Console.ReadLine()!);
int[] array = GenerateArray(SizeArray, MinBorder, MaxBorder);
PrintArray(array);
int SumNumber = SumOddPosition(array);
Console.WriteLine($"Сумма элементов стоящих на нечётных позициях - " + SumNumber);
int[] GenerateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int SumOddPosition(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}