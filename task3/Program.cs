// Программа которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число ");
int n = int.Parse(Console.ReadLine());

double f(int i)
{
    return Math.Pow(i, 3);
}
for (int i = 1; i <= n; i++)
{

    Console.Write($"{f(i)}");
    if (i < n)
    {
        Console.Write(",");
    }
}
Console.WriteLine();