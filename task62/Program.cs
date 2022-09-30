// Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] numbers = new int[4, 4];
Fill(0, 0, 1);
Print2DMatrix(numbers);

void Fill(int i, int j, int count)
{
    if (i >= 0 && j >= 0 && i < 4 && j < 4 && numbers[i, j] == 0)
    {
        numbers[i, j] = count;
        Fill(i, j + 1, count + 1);
        Fill(i + 1, j, count + 1);
        Fill(i, j - 1, count + 1);
        Fill(i - 1, j, count + 1);
    }
}

void Print2DMatrix(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write($"{numbers[i, j],3}");
        }
        Console.WriteLine();
    }
}

