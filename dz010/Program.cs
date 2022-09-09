// Напишите программу, которая принимает на вход трёхзначное 
//число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число:");
int number = int.Parse(Console.ReadLine()); 

int digit = (number / 10) % 10;

if (number < 100 || number > 999)
    Console.WriteLine($"Число {number} не трехзначное!");
else 
    Console.Write($"Вторая цифра этого числа {digit}");


