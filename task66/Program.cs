// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите натуральное число M ");
int numberM = int.Parse(Console.ReadLine()!);

Console.Write("Введите натуральное число N ");
int numberN = int.Parse(Console.ReadLine()!);

Console.WriteLine(GetSumBetweenNaturalMAndN(numberM, numberN));

int GetSumBetweenNaturalMAndN(int numberM, int numberN)
{
    if (numberM < 1 || numberN < 1)
    {
        throw new Exception("Число не натуральное ");
    }
    if (numberM > numberN)
    {
        throw new Exception("Число M должно быть меньше N ");
    }
    if (numberN == numberM)
        return numberN;
    return numberN + GetSumBetweenNaturalMAndN(numberM, numberN - 1);
}

