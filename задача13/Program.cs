Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine());
if (number > 100)
    Console.WriteLine($"{number % 10}");
else
    Console.WriteLine("третьей цифры нет");


