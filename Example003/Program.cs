// Эта программа принимает число дня недели и на выходе выдаёт является, 
// этот день выходным. 

Console.WriteLine("Введите число дня недели");
double DayWeek = int.Parse(Console.ReadLine());

if (DayWeek == 6 || DayWeek == 7)
{
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("Будни");
}


