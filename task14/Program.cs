﻿

// 14. напишите программу которая:
// 1принимает на вход число
// проверяет кратно ли оно одновременно 7и23


bool DevidedByTwoNumbers(int num, int num1, int num2)
{
    return num % num1 == 0 && num % num2 == 0;
   
}
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
bool myresult = DevidedByTwoNumbers(number, 7, 27);
Console.WriteLine(myresult ? "Да" : "нет");
