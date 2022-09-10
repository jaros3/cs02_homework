// Напишите программу, которая выводит третью 
//цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());

while(number > 1000)
    number = number / 10;

if(number > 100 && number < 1000)
{
    int digit = number % 10;
        Console.WriteLine($"Третья цифра в числе: {digit}");
}
else 
    {
        Console.WriteLine($"В числе {number} третьей цифры нет");
    }


