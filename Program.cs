//Задача 15:Напишите программу, которая принимает на вход цифру, обозначающую день недели,и проверяет, является ли этот день выходным.

Console.WriteLine("Введите порядковый номер дня недели:");
int number = int.Parse(Console.ReadLine());

if (number > 0 && number < 6)
{
    Console.WriteLine("Этот день рабочий");
}
else
{
 if (number == 6 || number == 7)
{
    Console.WriteLine("Это выходной день");
}
else
{
    Console.WriteLine("Опечатка, число должно быть от 1 до 7");
}
}