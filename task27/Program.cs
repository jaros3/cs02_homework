// 
int FindSumOfDigits(int num)
{ 
    int sum = 0;
    while (num > 0)
    {
        sum += num%10;
        num = num/10;
    }
    return sum;
}
Console.Write("Введите N. ");
bool isNumCorrect = false;
int inputNum = 0;
while (!isNumCorrect)
{
    Console.WriteLine("Число должно быть целым. ");
    isNumCorrect = int.TryParse(Console.ReadLine()!, out inputNum);
}
Console.WriteLine($"Сумма цифр в числе {inputNum} это {FindSumOfDigits(inputNum)}");
