// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве
// Размер массива вводим через консоль
// [345, 897, 568, 234] -> 2

Console.Write("Введите размер массива: ");
int SizeArray = int.Parse(Console.ReadLine()!);
int[] array = GenerateArray(SizeArray, 100, 999);
PrintArray(array);
int QuantityNumber = CountNumber(array);
Console.WriteLine($"Количество чётных чисел - " + QuantityNumber);
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
int CountNumber(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) counter++;
    }
    return counter;
}