// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
Console.WriteLine("Введите вещественные числа через пробел, например число 5 как 5,0  число 7,7 -> 7,7");

double[] numbers = CreateArray();

double differenceNum = CalcDifferenceNum(numbers);

PrintArray(numbers);

Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {differenceNum}");

double[] CreateArray()
{
    string[] strArray = Console.ReadLine().Split(" ");
    double[] numArray = new double[strArray.Length];
    for (int i = 0; i < strArray.Length; i++)
    {
        numArray[i] = double.Parse(strArray[i]);
    }
    return numArray;
}
void PrintArray(double[] array)
{
    Console.WriteLine($"[{string.Join(",", array)}]");
}

double CalcDifferenceNum(double[] numbers)
{
    double max = double.MinValue;
    double min = double.MaxValue;

    foreach (double number in numbers)
    {
        if (number > max)
            max = number;


        if (number < min)
            min = number;
    }
    return max - min;
}
