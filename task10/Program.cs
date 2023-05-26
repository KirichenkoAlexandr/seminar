// Задача 10: Напишите программу,
// 1. которая принимает на вход трёхзначное число и
// 2. на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int ShowSecondDigit(int number)
{
    int num = number /10 % 10;

    return num;
}

Console.WriteLine("Введите 3-х значное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number< 100 ||  number>= 1000)
{
    Console.WriteLine("Введено неверное число");
    return;

}
int secondDigit = ShowSecondDigit(number);
Console.WriteLine($"вторая цифра {secondDigit} ");