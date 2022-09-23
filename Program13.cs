//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

while(number > 999)
{
number = number / 10;
}

if(number > 99 && number < 1000)
{
Console.WriteLine($"Третья цифра этого числа {number % 10}");
}
else 
{
Console.WriteLine("третьей цифры нет");
}