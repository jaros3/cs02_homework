// 
Console.WriteLine("Введите число А ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B ");
int numberB = int.Parse(Console.ReadLine());

double degree = Math.Pow(numberA, numberB);

Console.WriteLine($"{degree}");
