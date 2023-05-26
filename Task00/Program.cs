// 0. Демонстрация решения
// Напишите программу, которая на

// 1. вход принимает число и выдаёт его квадрат
// 2. (число умноженное на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49 

Console.WriteLine("ВВедите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine($"Kвадрат числа {number} = {square}");
