// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string numText = Convert.ToString(num);
if (numText.Length > 2)
{
    Console.WriteLine("Вторая цифра числа:" + numText[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет.");
}



