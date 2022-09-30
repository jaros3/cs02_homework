// Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int heigth = EnterInt("Enter integer heigth: ");
int width = EnterInt("Enter integer width: ");

int[,] numbers = new int[heigth, width];
Fill2DArray(numbers, heigth, width);
Print2DArray(numbers, heigth, width);
Console.WriteLine("result");
FindMinRows2DArray(numbers, heigth, width);

int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

void Fill2DArray(int[,] numbers, int heigth, int width)
{
    for (int i = 0; i < heigth; i++)
    {
        for (int j = 0; j < width; j++)
        {
            numbers[i, j] = new Random().Next(-9, 10);
        }
    }
}

void Print2DArray(int[,] numbers, int heigth, int width)
{
    for (int i = 0; i < heigth; i++)
    {
        for (int j = 0; j < width; j++)
        {
            Console.Write($"{numbers[i, j],3}");
        }
        Console.WriteLine();
    }
}

void FindMinRows2DArray(int[,] numbers, int heigth, int width)
{
    int minRow = 0;
    int minSum = 10000;
    for (int i = 0; i < heigth; i++)
    {
        int sum = 0;
        for (int j = 0; j < width; j++)
        {
            sum = sum + numbers[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            minRow = i;
        }
        Console.WriteLine($" {sum}");
    }
    Console.WriteLine($"minRow = {minRow} ");
}


