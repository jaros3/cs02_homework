// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int heigth = EnterInt("Enter integer heigth: ");
int width = EnterInt("Enter integer width: ");

int[,] numbers = new int[heigth, width];
Fill2DArray(numbers, heigth, width);
Print2DArray(numbers, heigth, width);
CountArithmeticMeanOfItem2DArray(numbers, heigth, width);

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

void CountArithmeticMeanOfItem2DArray(int[,] numbers, int heigth, int width)
{
    for (int j = 0; j < width; j++)
    {
        double sum = 0;
        for (int i = 0; i < heigth; i++)
        {
            sum = sum + numbers[i, j];
        }
        double average = sum / heigth;
        Console.WriteLine($"Average of {j} row = {average:F3}");
    }
}

