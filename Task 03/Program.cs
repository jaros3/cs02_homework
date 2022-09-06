//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите цифру, день недели: ");
int DayofTheWeek = int.Parse(Console.ReadLine());
if (DayofTheWeek > 0 && DayofTheWeek < 6)
{
    Console.WriteLine("Это будний день, надо на работу");
}
else if (DayofTheWeek == 6 || DayofTheWeek == 7)
{
    Console.WriteLine("Это выходной!");

}
else
{
    Console.WriteLine("Вы ввели неверную команду, введите день недели от 1 до 7");
}