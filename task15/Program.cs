﻿// Задача 15: Напишите программу, которая
// 1. принимает на вход цифру, обозначающую день недели,
// 2. и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool IsWeekend(int weekDay)
{
    if (weekDay > 5)
    {
        return true;
    }
    return false;
}

bool ValidateWeekday(int number)
{
    if (number > 0 && number <= 7)
    {
        return true;
    }
    Console.WriteLine("это не день недели");
    return false;
}
int weekDay = Prompt("введите день недели >");
if (ValidateWeekday(weekDay))
{
    if (IsWeekend(weekDay))
    {
        Console.WriteLine("ура выходной!");
    }
    else
    {
    Console.WriteLine("прийдется поработать");
    }
}