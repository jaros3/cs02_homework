//Эта прграмма выводит третью цифру заданного числа или сообщает, что такой цифры нет

Console.WriteLine("введите число");
int number = int.Parse(Console.ReadLine());

if (number < 100)
{
    Console.Write("третьей цифры нет");
}
else
{
    while (number >= 1000)
    {
        number = number / 10;
    }

    if (number < 1000)
    {
        int result = (number % 100) % 10;
        Console.Write($"Третья цифра числа = {result}");
    }
}