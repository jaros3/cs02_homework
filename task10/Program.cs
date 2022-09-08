//На вход трехзначное число, на выход вторую цифру этого числа

Console.WriteLine("Введите трехзначное число ");
int number = int.Parse(Console.ReadLine());

int result = number/10 % 10;

Console.WriteLine(result); 
