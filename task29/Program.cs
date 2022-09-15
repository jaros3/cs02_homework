// Задача 29: Введите 8 чисел. Поместите в массив и распечатайте.
int[] CreateArray(int size)
{
    int[] numArray = new int[size];
    string[] strArray = Console.ReadLine().Split(" ");
    for (int i = 0; i < size; i++)
    {
        if (i >= strArray.Length)
        {
            numArray[i] = 0;
        }
        else
        {
            numArray[i] = int.Parse(strArray[i]);
        }
    }
    return numArray;
}
void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(",", array)}]");
}
Console.WriteLine("Введите 8 чисел");
PrintArray(CreateArray(8));
Console.WriteLine();
