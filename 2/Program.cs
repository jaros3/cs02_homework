// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
while (true) // Зацикливание программы
{
    int NumChecker() //метод проверки на ввод числа
    {
        int isItNum = -1;
        bool check;
        string num = "q";
        Console.WriteLine("   //число для подолжения, или *q* чтоб выйти");
        do
        {

            num = Console.ReadLine();
            if (num == "q")
            {

                break;
            }
            else
            {
                check = int.TryParse(num, out isItNum);
            }
        } while (check == false);

        if (num == "q")
        {
            Console.WriteLine($"Вы не ввели число");
            System.Environment.Exit(0); //завершение программы на любом этапе
        }
        return isItNum;
    }

    //Основной код дз
    //------------------------------------------------------------------------------------------
    Console.Write("Введите число.");

    int Num = NumChecker(); //вместо обычного ReadLine, сразу проверяет, что число целое
    string numSt = Num.ToString(); //преобразуем обратно в строку, чтобы можно было достать 3е число без лишних действий

    if (Num / 100 > 0) //проверяем, что число содержит 3ю цифру
    {
        Console.WriteLine($"Третья цифра в {Num} -> {numSt[2]}");
    }
    else
    {
        Console.WriteLine($"В {Num} нет третей цифры");
    }
    //------------------------------------------------------------------------------------------

    //Зацикливание программы

    Console.WriteLine("Enter чтобы продолжить / q чтобы выйти");
    ConsoleKeyInfo quite = Console.ReadKey();
    Console.WriteLine();
    if (quite.KeyChar == 'q') break;
}