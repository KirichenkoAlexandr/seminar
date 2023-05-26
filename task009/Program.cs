// 9.напишите программу,которая
// 1выводит случайное числог из отрезка[10,99]
// 2показывает последнюю цифру максимального числа.

int number = new Random().Next(10, 100);//для того чтобы включить в диапозон последнее 2-х значное число необходимо +1
Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {number}");
// int firstDigit = number / 10; //для получения целочисленного остатка например 78/10=7
// int secondDigit = number % 10; // для получения дробногоостака 
// // 1 способ:
// if (firstDigit > secondDigit)
//     Console.WriteLine($"наибольшая цифра -> {firstDigit}");
// else
//     Console.WriteLine($"наибольшая цифра -> {secondDigit}");

// //2 способ:

// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit; //тернарный оператор.
// Console.WriteLine($"наибольшая цифра -> {maxDigit}");



//3способ:

int maxDigit = MaxDigit(number);
Console.WriteLine($"наибольшая цифра -> {maxDigit}");

int MaxDigit(int num) // num = number
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;

    return maxDigit;
}