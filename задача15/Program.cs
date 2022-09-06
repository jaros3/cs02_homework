//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите день недели от 1 до 7");
int number = int.Parse(Console.ReadLine());
if (number < 1 || number > 7)
    Console.WriteLine("Это не день недели, введите число от 1 до 7");
else if (number == 6 || number == 7)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}

