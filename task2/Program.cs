// Программа которая принимает на вход координаты двух точек и находит расстояние между ними в пространстве 3D.

Console.WriteLine("Введите через пробел координаты x,y,z для точки A ");
string xAyAzA = Console.ReadLine()!;
string[] parts1 = xAyAzA.Split(' ');
int xA = int.Parse(parts1[0]);
int yA = int.Parse(parts1[1]);
int zA = int.Parse(parts1[2]);

Console.WriteLine("Введите через пробел координаты x,y,z для точки B ");
string xByBzB = Console.ReadLine()!;
string[] parts2 = xByBzB.Split(' ');
int xB = int.Parse(parts2[0]);
int yB = int.Parse(parts2[1]);
int zB = int.Parse(parts2[2]);

double distance(int xA, int yA, int zA, int xB, int yB, int zB)
{
    return Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2));
}
Console.WriteLine($"Расстояние между точками A и B = {distance(xA, yA, zA, xB, yB, zB):F2}");





