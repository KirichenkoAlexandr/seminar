// Задача 13: Напишите программу, которая
// 1. выводит третью цифру заданного числа
// 2. или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int XYZ(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int ShowThridDigit(int number)
{
    while (number > 999)
    {
        number /=10;
    }
    return number % 10;
}

bool NoThridDigit(int number)
{
if (number < 100)
{
    Console.WriteLine("нет третьей цифры");
    return false;
}
return true;
}
int number = XYZ("Введите число ");
if (NoThridDigit (number))
{
    Console.WriteLine(ShowThridDigit(number));
}

