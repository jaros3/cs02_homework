Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

int count = 0;
int digit = 0;
int currentNumber = number;


while(currentNumber!=0)
{
    currentNumber = currentNumber / 10;
    count++;

}

if(count == 3)
{
    digit = number % 10;
    Console.WriteLine($"Третья цифра = {digi

}
if (count > 3)
{
for(int i = 0;i < count - 3; i++)
{
    number = number / 10;
}
   
    
 digit = number % 10;
 Console.WriteLine($"Третья цифра = {digit}"
    
}
if (count < 3)
{
    Console.WriteLine("Третьей цифры нет");

}