// Задача 25:
// Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.
int InputNatural()
{
    Console.Write("Введите B. ");
    bool isNumCorrect = false;
    int inputNum = 0;
    while (!isNumCorrect)
    {
        Console.WriteLine("Число должно быть натуральным. ");
        isNumCorrect = int.TryParse(Console.ReadLine()!, out inputNum);
        if(inputNum <= 0)
        {
            isNumCorrect = false;
        }
    }
    return inputNum;
}
int InputNumber()
{
    Console.Write("Введите A. ");
    bool isNumCorrect = false;
    int inputNum = 0;
    while (!isNumCorrect)
    {
        Console.WriteLine("Число должно быть целым. ");
        isNumCorrect = int.TryParse(Console.ReadLine()!, out inputNum);
    }
    return inputNum;
}
int PowNatural(int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result *= numberA;
    }
    return result;
}

int numberA = InputNumber();

int numberB = InputNatural();

int degree = PowNatural(numberA, numberB);

Console.WriteLine($"Результат возведения числа {numberA} в степень {numberB} = {degree}");
