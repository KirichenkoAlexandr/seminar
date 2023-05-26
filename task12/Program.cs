// 12. напишите программу которая: // остаток от деления на 34 /5 = 4; 16/4  кратно
// 1 принимает на вход 2 числа (инт)
// 2 выводит является ли первое кратным второму
// 3если первое не кратно 2, то выдает остаток от деления

int Remainder(int num1, int num2)
{
    int remainder = num1 % num2;
    return remainder;
}


Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

int remainder = Remainder(number1, number2);
if (remainder==0)
{
    Console.WriteLine($"число {number1} кратное {number2}");

}
else
{
    Console.WriteLine($"число{number1} не кратное {number2} - остаток от деления {remainder}");
}