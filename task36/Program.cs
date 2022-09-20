// Задайте одномерный массив заполненный случайными числами. Найдите сумму элементов, стоящих на нечетных позициях.
int[] numbers = CreateRandomArray(12);
int oddNum = CalcOddPosition(numbers);
PrintArray(numbers);
Console.WriteLine($"Сумма элементов на нечетных позициях в массиве = {oddNum}");
void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(",", array)}]");
}

int[] CreateRandomArray(int size)
{
    int[] numbers = new int[size];
    for (int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(-10, 11);
    }
    return numbers;
}
int CalcOddPosition(int[] numbers)
{
    int sum = 0;
    for (int i = 1; i < numbers.Length; i = i + 2)
        sum = numbers[i] + sum;

    return sum;
}
