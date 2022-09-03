//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

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

    Console.Write("Введите трехзначное число.");
    int Num = NumChecker(); //вместо обычного ReadLine, сразу проверяет, что число целое

    if (Num > 100 && Num < 1000)
    {
        int digit = (Num / 10) % 10; //Заранее известно, что число 3х значное, можно достать нужную цифру математикой, иначе можно было бы преобразовать в строку, и достать нужную цифру по индексу string[n]
        Console.WriteLine($"Вторая цифра в {Num} -> {digit}");
    }
    else
    {
        Console.WriteLine($"Число {Num} не является трехзначным");
    }
    //------------------------------------------------------------------------------------------

    //Зацикливание программы   

    Console.WriteLine("Enter чтобы продолжить / q чтобы выйти");
    ConsoleKeyInfo quite = Console.ReadKey();
    Console.WriteLine();
    if (quite.KeyChar == 'q') break;
}