// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите порядковый номер дня недели (1-7): ");
int num = Convert.ToInt32(Console.ReadLine());

if(num >= 1 && num <=7)
 
 if(num == 1)
{
    Console.WriteLine("ПН");
}
else if(num == 2)
{
    Console.WriteLine("ВТ");
}
else if(num == 3)
{
    Console.WriteLine("СР");
}
else if(num == 4)
{
    Console.WriteLine("ЧТ");
}
else if(num == 5)
{
    Console.WriteLine("Пт");
}
else if(num == 6)
{
    Console.WriteLine("Сб");
}
else if(num == 7)
{
    Console.WriteLine("ВС");
}
else

    Console.WriteLine("Напоминаем в недели 7 дней уважаемый)");


