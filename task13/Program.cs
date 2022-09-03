//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("enter a number consisting of three elements");

int number = int.Parse(Console.ReadLine());

if (number >= 100 && number <= 999)
    {
        Console.WriteLine("third element of number is: " + number % 10);

    }
else if(number <= 99 || number >= 1000)
    {
        Console.WriteLine("--third digit does not exist or these are more then three digits--");
    }