//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введи число");
string threeDigitNumber = Console.ReadLine();

if (threeDigitNumber.Length < 3)
{
    Console.WriteLine($"В числе {threeDigitNumber} нет третьей цифры");
}
else
{
    Console.WriteLine($"Третья цифра числа {threeDigitNumber} = {threeDigitNumber[2]}");
}