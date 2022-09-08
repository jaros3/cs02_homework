// Найти третью цифру числа или сообщить, что её нет

Console.WriteLine();

int Number = new Random().Next(1, 1500);

Console.WriteLine($"Дано число: {Number}");

if (Number / 100 > 0)
{
    Console.WriteLine($"Третьей цифрой числа {Number} является цифра {Number / 1 % 10}");
}
else
{
    Console.WriteLine($"У числа {Number} нет третьей цифры");
}
