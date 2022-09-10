// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 

// Первый вариант решения

// Console.WriteLine("Введите пятизначное число ");
// string abcde = Console.ReadLine()!;
// //string[] parts = abcde.Split(' ');

// int a = int.Parse(abcde[0].ToString());
// int b = int.Parse(abcde[1].ToString());
// int c = int.Parse(abcde[2].ToString());
// int d = int.Parse(abcde[3].ToString());
// int e = int.Parse(abcde[4].ToString());

// if (a == e && b == d)
// {
//     Console.WriteLine($"Число {abcde} является палиндромом");
// }
// else
// {
//     Console.WriteLine($"Число {abcde} не является палиндромом");
// }

//Второй вариант решения

Console.WriteLine("Введите число ");
string abcde = Console.ReadLine()!;

bool isPalindrom(string abcde)
{
    for (int index = 0; index <= abcde.Length / 2; index++)
    {
        if (abcde[index] != abcde[abcde.Length - index - 1])
        {
            return false;
        }
    }
    return true;
}
if (isPalindrom(abcde))
{
    Console.WriteLine($"Число {abcde} является палиндромом");
}
else
{
    Console.WriteLine($"Число {abcde} не является палиндромом");
}










