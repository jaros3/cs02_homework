// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве и возвращает значение этого элемента, или же указание что такого элемента нет.

int heigth = EnterInt("Enter heigth: ");
int width = EnterInt("Enter width: ");

double[,] numbers = new double[heigth, width];
Fill2DArray(numbers, heigth, width);
Print2DArray(numbers, heigth, width);

int row = EnterInt("Enter row: ");
int column = EnterInt("Enter column: ");
Print2DArrayNumber(numbers, row, column);

int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

double NextDouble(double minValue, double maxValue)
{
    return new Random().NextDouble() * (maxValue - minValue) + minValue;
}

void Fill2DArray(double[,] numbers, int heigth, int width)
{
    for (int i = 0; i < heigth; i++)
    {
        for (int j = 0; j < width; j++)
        {
            numbers[i, j] = NextDouble(-10, 10);
        }
    }
}

void Print2DArray(double[,] numbers, int heigth, int width)
{
    for (int i = 0; i < heigth; i++)
    {
        for (int j = 0; j < width; j++)
        {
            Console.Write($"{numbers[i, j],8:F4}");
        }
        Console.WriteLine();
    }
}

void Print2DArrayNumber(double[,] numbers, int row, int column)
{
    if (row >= 0 && row < numbers.GetLength(0) && column >= 0 && column < numbers.GetLength(1))
    {
        Console.WriteLine($"Значение элемента в позиции {row} и {column} = {numbers[row, column],8:F4}");
    }
    else
    {
        Console.WriteLine($"В позиции {row} и {column} элемент отсутствует");
    }
}