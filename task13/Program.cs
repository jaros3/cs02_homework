int number = new Random().Next(0, 1000);
Console.WriteLine(number);

if (number < 100)
{
    Console.WriteLine("Третьего числа нет");
}
else if (number < 1000)
{
    Console.WriteLine(number % 10);
}
else
{
    string str = number.ToString();
    Console.WriteLine(number);
    Console.WriteLine(str[2]);
}
