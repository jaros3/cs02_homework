//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
if (number > 99) {
    char num = number.ToString()[2];
    Console.WriteLine($"{num}"); }
else
    Console.WriteLine("третьей цифры нет");


