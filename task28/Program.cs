// Задача28.
// Напиши программу которая принимант на вход число N 
// и выдает произведение чисел от 1 доN.

int Factorial(int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            result *= i;
        }
    }
    return result;
}

int Start(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = Start("Введите целое положительное число");
if (number <= 0)
{
    Console.WriteLine("Вы ввели некорректное число");
    return;
}
Console.WriteLine(Factorial(number));