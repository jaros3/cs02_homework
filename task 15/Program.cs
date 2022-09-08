// На вход цифра обозначающая день недели, и проверяет, является ли этот день выходным

Console.WriteLine("Введите цифру ");
int digit = int.Parse(Console.ReadLine());

if(digit <= 5 && digit > 0) 
{
    Console.WriteLine($"День {digit} будний" );
}
else if(digit <= 7 && digit > 0) 
{
    Console.WriteLine($"День {digit} выходной");
}
else 
{
    Console.WriteLine($"День {digit} введен неверно");
}

