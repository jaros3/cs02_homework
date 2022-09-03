//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine());
if (number > 100)
    Console.WriteLine($"{number % 10}");
else
    Console.WriteLine("третьей цифры нет");


