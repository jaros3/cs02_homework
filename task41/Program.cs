// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввел пользователь.

Console.WriteLine("Введите числа через пробел ");
int[] numbers = CreateArray();
PrintArray(numbers);
Console.WriteLine($"Количество чисел больше 0 в данном массиве = {CalcNum(numbers)}");


int[] CreateArray()
{
    string[] strArray = Console.ReadLine().Split(" ");
    int[] numArray = new int[strArray.Length];
    for (int i = 0; i < strArray.Length; i++)
    {
        numArray[i] = int.Parse(strArray[i]);
    }
    return numArray;
}
void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(",", array)}]");
}
int CalcNum(int[] numbers)
{
    int count = 0;
    foreach (int number in numbers)
    {
        if (number > 0)
            count++;
    }
    return count;
}
