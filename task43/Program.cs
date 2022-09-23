// Задача 43. Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями y = k1*x + b1, y = k2*x + b2; значения b1,k1,b2,k2 задаются пользователем.

double k1 = InputNumber("Введите значение k1 ");
double k2 = InputNumber("Введите значение k2 ");
double b1 = InputNumber("Введите значение b1 ");
double b2 = InputNumber("Введите значение b2 ");
double[] result = CalcValue(k1, k2, b1, b2);
if (result == null)
{
    Console.WriteLine($"Прямые параллельны друг другу, так как значения k1=k2");
}
else
{
    Console.WriteLine($"Точка пересечения двух прямых [{result[0]:f3};{result[1]:f3}]");
}

double InputNumber(string msg)
{
    Console.WriteLine(msg);
    bool isNumCorrect = false;
    double inputNum = 0;
    while (!isNumCorrect)
    {
        Console.WriteLine("Число должно быть вещественным. ");
        isNumCorrect = double.TryParse(Console.ReadLine()!, out inputNum);
    }
    return inputNum;
}

double[] CalcValue(double k1, double k2, double b1, double b2)
{
    if ((Math.Abs(k1 - k2) >= 0.0001))
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        return new double[2] { x, y };
    }
    return null;
}
