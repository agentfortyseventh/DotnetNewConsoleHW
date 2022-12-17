// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива
// Размер массива, минимальное значение и максимальное значение вводим через консоль
// Для генерации вещественных чисел, по аналогии с int, есть функция NextDouble()
// [3 7 22 2 78] -> 76

Console.Write("Введите размер массива: ");
int SizeArray = int.Parse(Console.ReadLine()!);
Console.Write("Диапазон от: ");
int MinBorder = int.Parse(Console.ReadLine()!);
Console.Write("Диапазон до: ");
int MaxBorder = int.Parse(Console.ReadLine()!);
double[] array = GenerateDoubleArray(SizeArray, MinBorder, MaxBorder);
PrintArray(array);
double min = Int32.MaxValue;
double max = Int32.MinValue;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}
Console.WriteLine($"Разница между максимальным и минимальным значением - {max - min}");
double[] GenerateDoubleArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        double number = new Random().NextDouble() * (maxValue - minValue) + minValue;
        array[i] = Math.Round(number, 2);
    }
    return array;
}
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}