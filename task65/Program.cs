// задача 65. Задайте значение M и N. Напишите программу, которая
// выведет все натуральные числа от М до N
// M=1; N=5->1,2,3,4,5
// M=4;N=8->4,5,6,7,8

System.Console.WriteLine("Вdедите два натуральных числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
NaturalNumbersInRange(number1,number2);
void NaturalNumbersInRange(int num1, int num2)
{
    if (num1 < num2)
    {
        System.Console.Write($"{num1}, ");
        NaturalNumbersInRange(num1 + 1, num2);
    }

    else if (num2 < num1)
    {
        System.Console.Write($"{num2}, ");
        NaturalNumbersInRange(num1, num2 + 1);
    }
    else
    {
        System.Console.Write($"{num1}");
    }
}    