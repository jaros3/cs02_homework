// Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите порядковый номер дня недели:");
int number = int.Parse(Console.ReadLine());

if (number < 1 || number > 7)
    Console.WriteLine("Введены некорректные данные");
else if (number == 6 || number == 7)
    Console.WriteLine("Это выходной!");
else
    Console.WriteLine("Это рабочий день");
