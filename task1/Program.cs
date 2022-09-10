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

// Второй вариант решения
Console.WriteLine("Введите число ");
string abcde = Console.ReadLine()!;

bool isPalindrom = true;
//предполагаем, что введенное число палиндром (проверяем до середины числа циклом противолежащие элементы, если цифры не равны то isPolindrom = false)
for (int index = 0; index <= abcde.Length/2; index++)
{  
    if (abcde[index] != abcde[abcde.Length - index - 1])
    {
        isPalindrom = false;
        break;
    }
} 
if (isPalindrom)
{
    Console.WriteLine($"Число {abcde} является палиндромом");
}
else
{
    Console.WriteLine($"Число {abcde} не является палиндромом");
}




//int [] numbers = new int [5];

// for (int index = 0; index < numbers.Length; index++) ;
// {
//     if (numbers[index] == numbers[numbers.Length - index])
//     {
//         break;
//         Console.WriteLine($"Число {numbers} является палиндромом");
//     }
//     else
//     {
//         Console.WriteLine($"Число {numbers} не является палиндромом");
//     }




