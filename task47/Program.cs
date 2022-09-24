// Задача 47. Задайте двумерный массив размером m*n, заполненный случайными вещественными числами.

int heigth = EnterInt("Enter heigth: ");
int width = EnterInt("Enter width: ");

double[,] numbers = new double[heigth, width];
Fill2DArray(numbers, heigth, width);
Print2DArray(numbers, heigth, width);

int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

double NextDouble(double minValue,double maxValue)
{
    return new Random().NextDouble() * (maxValue - minValue) + minValue;
}

void Fill2DArray(double[,] numbers, int heigth, int width)
{
    for (int i = 0; i < heigth; i++)
    {
        for (int j = 0; j < width; j++)
        {
            numbers[i, j] = NextDouble(-10,10);
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

