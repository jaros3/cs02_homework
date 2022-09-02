//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
while (true) // Зацикливание программы
{
    Console.WriteLine("Введите день недели по счету.");
    ConsoleKeyInfo day = Console.ReadKey(); // в задаче говорится про цифру, а не число, решил сделать через ReadKey
    Console.WriteLine();

    int wDay = day.KeyChar - 48; // номер цифры 1 это 49, 2 - 50 и тд, по этому -48

    if (wDay > 5 & wDay < 8)
    {
        Console.WriteLine("Ура Выходной!");
    }
    else if (wDay < 6)
    {
        Console.WriteLine("Нее, сегодня опять на работку((");
    }
    else Console.WriteLine("Друг, в неделе всего 7 дней, порпобуй еще.");

    //Зацикливание программы   

    Console.WriteLine("Enter чтобы продолжить / q чтобы выйти");
    ConsoleKeyInfo quite = Console.ReadKey();
    Console.WriteLine();
    if (quite.KeyChar == 'q') break;
}