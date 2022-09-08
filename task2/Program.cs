/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 
*/

Console.WriteLine("ввести число ");
int number = int.Parse(Console.ReadLine());

if (number < 100)
{
    Console.Write("Третья цифра отсутствует");
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
        Console.Write($"3-я цифра числа = {result}");
    }
}
