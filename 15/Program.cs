//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

string[] daysOfWeek = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
Console.WriteLine("Введи цифру обозначающую день недели");
int day = int.Parse(Console.ReadLine());

if (day == 6 || day == 7)
{
    Console.WriteLine($"{daysOfWeek[day - 1]} выходной");
}
else if (day > 0 && day < 6) {
    Console.WriteLine($"{daysOfWeek[day - 1]} не выходной");
}
else
{
    Console.WriteLine("Такого дня недели не придумали еще. Введи цифру от 1 до 7");
}