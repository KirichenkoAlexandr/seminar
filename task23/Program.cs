// Задача 23
// Напишите программу,
//  которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125
Console.Write("Введите наутральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

WriteLinesSquare(number);

void WriteLinesSquare(int number)
{
    int i = 1;
    while (i <= number)
    {
        int square = i * i *i;
        Console.WriteLine($"{i,3} -> {square,4}");
        i++;
    }
}