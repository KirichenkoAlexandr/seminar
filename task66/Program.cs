// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
//  Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int EnterNumbers(string message)
{

    Console.Write(message);
    int data = Convert.ToInt32(Console.ReadLine()!);
    Console.WriteLine();
    return data;
}
int GetStrSum(int number1, int number2)
{
    if (number1 == number2)
    {
        return number1;
    }
    return number1 + GetStrSum(number1 + 1, number2);
}

int number1 = EnterNumbers("Введите значение начала ряда: ");
int number2 = EnterNumbers("Введите значение конца ряда: ");

int start = Math.Min(number1, number2);
int finish = Math.Max(number1, number2);

int sum = GetStrSum(start, finish);
Console.WriteLine($"Сумма натуральных элементов в промежутке от {start} до {finish} = {sum}");
Console.WriteLine();