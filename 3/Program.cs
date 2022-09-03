//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
while (true) // Зацикливание программы
{
    Console.WriteLine();
    Console.WriteLine("Введите день недели по счету или *q* для выхода");
    ConsoleKeyInfo day = Console.ReadKey(); // в задаче говорится про цифру, а не число, решил сделать через ReadKey
    Console.WriteLine();

    int wDay = day.KeyChar - 48; // номер цифры 1 это 49, 2 - 50 и тд, по этому -48
    string[] dayName = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
    if (wDay > 5 && wDay < 8)
    {
        Console.WriteLine($"{dayName[wDay - 1]} - Ура Выходной!");
    }
    else if (wDay < 6)
    {
        Console.WriteLine($"{dayName[wDay - 1]} - На работку((");
    }
    else if (day.KeyChar == 'q') // Выход из while
    {
        Console.WriteLine("Приходите еще!");
        break;
    }

    else { Console.WriteLine("Друг, в неделе всего 7 дней, порпобуй еще."); }

}