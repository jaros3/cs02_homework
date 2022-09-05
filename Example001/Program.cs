// Э программа на вход принимает трёхзначное число и на выходе показывает
//  показывает вторую цифру этого числа

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int result1 = number / 10;
int result2 = result1 % 10;
Console.Write($"Вторая цифра числа = {result2}");
