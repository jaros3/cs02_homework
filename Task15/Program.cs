// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Пожалуйста, напишите номер дня недели: ");
int dayWeekNumber = int.Parse(Console.ReadLine());

if (dayWeekNumber <= 0 || dayWeekNumber > 7)
    Console.WriteLine("Вы ввели некорректное число. Попробуйте снова.");
else {
    if (dayWeekNumber <= 5)
    Console.WriteLine("Это рабочий день.");
    else Console.WriteLine("Это выходной день.");
}