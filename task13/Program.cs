// Вывод третьей цифры заданного числа или сообщение, что третьей цифры нет

//int number = new Random().Next(100,1000);
//int result = number%10;
//Console.WriteLine($"Третьей цифрой числа {number} является {result} ");

Console.WriteLine("Введите число "); // вывод строки в консоль
int number = int.Parse(Console.ReadLine()); // чтение строки и преобразование в целое число

int original = number; // сохранение оригинального числа в переменной 

while(number > 999) {
    number = number / 10; //цикл делим на 10 пока число больше 999
}
if(number >= 100) {
    int result = number % 10; //еслч число больше или равно 100, то полуаем остаток от деления на 10, что является третьей слева цифрой
    Console.WriteLine($" Третья цифра числа от {original} это {result}"); 
}
else {
    Console.WriteLine($"Третьей цифры у числа {original} нет");
}


