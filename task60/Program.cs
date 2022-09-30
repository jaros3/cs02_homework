// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int m = EnterInt("Enter integer m: ");
int n = EnterInt("Enter integer n: ");
int k = EnterInt("Enter integer k: ");

int[,,] numbers = new int[m, n, k];
Fill3DArray(numbers);
Print3DArray(numbers);
Console.WriteLine("result");

int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

void Fill3DArray(int[,,] numbers)
{
    List<int> list = new List<int>();
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            for (int k = 0; k < numbers.GetLength(2); k++)
            {
                int element = new Random().Next(10, 100);
                while (list.IndexOf(element) >= 0)
                {
                    element = new Random().Next(10, 100);
                }
                numbers[i, j, k] = element;
                list.Add(element);
            }
        }
    }
}

void Print3DArray(int[,,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            for (int k = 0; k < numbers.GetLength(2); k++)
            {
                Console.WriteLine($" Индексы {i},{j},{k} для соответсвующего элемента массива {numbers[i, j, k]}");
            }
        }

    }
}



