// Пользователь вводит с клавиатуры N-ое количество чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 3

Console.Write("Сколько чисел вывести? ");
int numbers = int.Parse(Console.ReadLine()!);
int[] array = GenerateArray(numbers, -100, 100);
PrintArray(array);
int quantityNumbers = CountNumbers(array);
Console.WriteLine("Чисел больше нуля " + quantityNumbers);
int[] GenerateArray(int anyNumber, int minValue, int maxValue)
{
    int[] array = new int[anyNumber];
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
int CountNumbers(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) counter++;
    }
    return counter;
}