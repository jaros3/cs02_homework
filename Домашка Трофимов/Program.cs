void FindSecondDigit(int number)
{

    if (number > 99)
    {   
        int SecondDigit = (number / 10) % 10;

        Console.WriteLine($"Вторая цифра трехзначного числа: {SecondDigit}");
    }
    else 
    {
        Console.WriteLine("Введите трехзначное число!");
    }
}   

Console.WriteLine("Введите трехзначное число: ");

int d = int.Parse(Console.ReadLine());

FindSecondDigit(d);
