// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число дня недели");
int number = int.Parse(Console.ReadLine());

if (number<= 5 && number >= 1)
System.Console.WriteLine("Нет, день недели не выходной");
else
System.Console.WriteLine("да, день недели выходной");
