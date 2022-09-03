// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int numberA = new Random().Next(100, 1000);
int digit2 = (numberA / 10) % 10;

Console.WriteLine(numberA);
Console.WriteLine(digit2);