// 11. напишите программу которая :
// 1 Выводит случайное 3-х  значное число
// 2удаляет 2-ю цифру этого числа.(инт)



int DeleteSecondDigit(int number)
{
    int firstDigit = number / 100;
    int secondDigit = number % 10;
    return firstDigit * 10 + secondDigit;
}

int number = new Random().Next(100, 1000);

Console.WriteLine($"трехзначное число - {number}");
int deleteSecondDigit = DeleteSecondDigit(number);
Console.WriteLine($"число без второй цифры-{deleteSecondDigit},");