//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введи трехзначное число");
string threeDigitNumber = Console.ReadLine();
Console.WriteLine($"Вторая цифра числа {threeDigitNumber[1]}");