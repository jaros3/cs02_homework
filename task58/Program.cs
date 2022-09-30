// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int m = EnterInt("Размерность m: ");
int n = EnterInt("Размерность n: ");
int k = EnterInt("Размерность k: ");

int[,] matrix1 = new int[m, n];
int[,] matrix2 = new int[n, k];

Console.WriteLine("Введите матрицу 1 размерности m*n ");
Fill2DMatrix(matrix1, m, n);
Print2DMatrix(matrix1, m, n);

Console.WriteLine("Введите матрицу 2 размерности n*k ");
Fill2DMatrix(matrix2, n, k);
Print2DMatrix(matrix2, n, k);

Console.WriteLine("Результат произведения двух матриц ");
var result = FindMultiplication2DMatrix(matrix1, matrix2);
Print2DMatrix(result, m, k);
int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

void Fill2DMatrix(int[,] numbers, int heigth, int width)
{
    for (int i = 0; i < heigth; i++)
    {
        for (int j = 0; j < width; j++)
        {
            Console.WriteLine($"Введите {i}, {j} элемент массива ");
            numbers[i, j] = int.Parse(Console.ReadLine());
        }
    }
}

void Print2DMatrix(int[,] numbers, int heigth, int width)
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

int[,] FindMultiplication2DMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); ++i)
        for (int j = 0; j < matrix2.GetLength(0); ++j)
            for (int k = 0; k < matrix2.GetLength(1); ++k)
                result[i, k] += matrix1[i, j] * matrix2[j, k];
    return result;
}
