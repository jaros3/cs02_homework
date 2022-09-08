/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

Console.Write("ввести трехзначное число от 100 до 999 включительно ");
string threeDigitNumber = Console.ReadLine();
Console.WriteLine(threeDigitNumber[1]);