// Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int heigth = EnterInt("Enter integer heigth: ");
int width = EnterInt("Enter integer width: ");

int[,] numbers = new int[heigth, width];
Fill2DArray(numbers, heigth, width);
Print2DArray(numbers, heigth, width);
SortRows2DArray(numbers, heigth, width);
Console.WriteLine("result");
Print2DArray(numbers, heigth, width);

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

void SortRows2DArray(int[,] numbers, int heigth, int width)
{
    // numbers[k,j];

    for (int k = 0; k < heigth; k++)
    {
        for (int i = 0; i < width - 1; i++)
        {
            int minPosition = i;
            for (int j = i + 1; j < width; j++)
            {
                if(numbers[k,j] < numbers[k,minPosition])
                {
                    minPosition = j;
                }
            }
            int temporary = numbers [k,i];
            numbers[k,i] = numbers[k,minPosition];
            numbers[k,minPosition] = temporary;
        }
    }

}

