// Задача 13: 
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.



Console.WriteLine("Придумайте n-значное целое число и введите его: ");
    string input1 = Console.ReadLine();
    int numberA = int.Parse(input1);

Console.WriteLine("Напишите количество знаков(цифр) из которого состоит это число: ");
    string input2 = Console.ReadLine();
    int numberB = int.Parse(input2);


if (numberB < 3) {
    
    Console.WriteLine("Упс, прости дружочек-пирожочек, но по условию задачи вынужден сообщить, что в задуманном тобой числе нет третьей цифры, попробуй еще разок)");
}
else {
    
int signNumber = numberB - 3;

double stepen = Math.Pow(10, signNumber);
int x = Convert.ToInt32(stepen);

int result = ((numberA / x) % 10);

Console.WriteLine("По условию задачи мы выводим на экран третью цифру придуманного тобой числа, и это цифра: ");
Console.WriteLine(result);
}


