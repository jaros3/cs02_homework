Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) 
{
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("Этот день выходной");
  }
  else if (dayNumber < 1 || dayNumber > 7) 
  {
    Console.WriteLine("Это не день недели");
  }
  else Console.WriteLine("Этот день не выходной");
}

CheckingTheDayOfTheWeek(dayNumber);