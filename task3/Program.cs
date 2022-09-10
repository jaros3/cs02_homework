// Программа которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{

    Console.Write($"{Math.Pow(i, 3)}");
    if (i < n)
    {
        Console.Write(",");
    }
}
Console.WriteLine();