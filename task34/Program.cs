// Задача 34: Задайте массив заполненный случайными положительными трехзначными числами. Напишите программу, которая покажет количество четных чисел в массиве.

int[] numbers = CreateRandomArray(12);
int evenNum = CalcEvenNum(numbers);
PrintArray(numbers);
Console.WriteLine($"Количество четных чисел в массиве = {evenNum}");
void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(",", array)}]");
}

int[] CreateRandomArray(int size)
{
    int[] numbers = new int[size];
    for (int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
    }
    return numbers;
}
int CalcEvenNum(int[] numbers)
{
    int count = 0;
    foreach (int number in numbers)
    {
        if (number % 2 == 0)
            count++;
    }
    return count;
}
