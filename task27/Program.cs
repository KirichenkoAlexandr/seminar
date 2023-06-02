// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (x > 0)
{
   int num  = x % 10;
   x= x/10;
   sum = sum+num;

}
Console.WriteLine($"сумма всех цифр в числе = {sum}");