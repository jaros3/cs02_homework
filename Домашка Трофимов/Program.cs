
void FindSecondDigit(int number)
{

    if (number > 99 && number < 1000)
    {   
        int SecondDigit = (number / 10) % 10;

        Console.WriteLine($"Вторая цифра трехзначного числа: {SecondDigit}");
    }
    else 
    {
        Console.WriteLine("Введите трехзначное число!");
    }
}   

void FindThirdDigit(int num)
{
    if (num > 99)
    {
        int ThirdDigit = (num / 100) % 10;
        Console.WriteLine($"Третья цифра числа: {ThirdDigit}");
    }
    else
    {
        Console.WriteLine("Третьей цифры нет!");
    }
}


void WeekendOrNot(int num)
{
    if (num >= 1 && num < 6)
    {
        Console.WriteLine("Нет! Надо на работу!");
    }

    if (num >= 6 && num <= 7)
    {
        Console.WriteLine("Да! Выходной, можно отдохнуть!");
    }
    if (num > 7) 
    {
        Console.WriteLine("Попробуйте ввести число от 1 до 7!");
    }
}



int lever = 0;
while (lever == 0)
{
    Console.WriteLine("Здравствуйте, пользователь!");
    Console.WriteLine();
    Console.WriteLine("Что бы вы хотели сегодня узнать?");
    Console.WriteLine("Показать меню? - нажмите Y");
    Console.WriteLine("Выйти - нажмите Q");
    var UserIn1 = Console.ReadLine();
    if (UserIn1.ToLower() == "y")
    {
        lever = 1;
    }
    else if (UserIn1.ToLower() == "q")
    {
        lever = -1;
    }
    while (lever == 1)
    {
        Console.Clear();
        Console.WriteLine("Меню: ");
        Console.WriteLine();
        Console.WriteLine("1. Показать вторую цифру числа");
        Console.WriteLine("2. Показать третью цифру числа");
        Console.WriteLine("3. Этот день выходной?");
        Console.WriteLine();
        Console.WriteLine("Введите номер пункта или нажмите 0 для выхода: ");
        int UserIn2 = Convert.ToInt32(Console.ReadLine());
          
        if (UserIn2 == 1)
        {
            Console.Clear();
            Console.WriteLine("Введите трехзначное число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            FindSecondDigit(num);
            Console.WriteLine("Нажмите M, чтобы вернуться в Меню");
            Console.WriteLine("Нажмите Q для выхода");
            string UserIn3 = Console.ReadLine(); 
            if (UserIn3.ToLower() == "m")
            {
                lever = 1;
            }
            else if (UserIn3.ToLower() == "q")
            {
                lever = -1;
            }
        }
        else if (UserIn2 == 2)
        {
            Console.Clear();
            Console.WriteLine("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            FindThirdDigit(num);
            Console.WriteLine("Нажмите M, чтобы вернуться в Меню");
            Console.WriteLine("Нажмите Q для выхода");
            string UserIn3 = Console.ReadLine(); 
            if (UserIn3.ToLower() == "m")
            {
                lever = 1;
            }
            else if (UserIn3.ToLower() == "q")
            {
                lever = -1;
            }
        }
        else if (UserIn2 == 3)
        {
            Console.Clear();
            Console.WriteLine("Введите номер дня недели цифрой: ");
            int numm = Convert.ToInt32(Console.ReadLine());
            WeekendOrNot(numm);
            Console.WriteLine("Нажмите M, чтобы вернуться в Меню");
            Console.WriteLine("Нажмите Q для выхода");
            string UserIn4 = Console.ReadLine(); 
            if (UserIn4.ToLower() == "m")
            {
                lever = 1;
            }
            else if (UserIn3.ToLower() == "q")
            {
                lever = -1;
            }

        }
    }
}