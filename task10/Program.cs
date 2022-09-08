// Показать вторую цифру трёхзначного числа

Console.WriteLine();

int number = new Random().Next(100, 1000);

Console.WriteLine($"Второй цифрой числа {number} является {number / 10 % 10} ");

