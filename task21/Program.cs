// // Напишите программу, которая
// //  принимает на вход координаты двух точек
// //   и находит расстояние между ними в 3D пространстве.
// // A (3,6,8); B (2,1,-7), -> 15.84
// // A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите координаты двух точек на плоскости: ");

Console.WriteLine("Введите значение X для первой точки: ");
int x1Coordinate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение Y для первой точки: ");
int y1Coordinate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение Z для первой точки: ");
int z1Coordinate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение X для второй точки: ");
int x2Coordinate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение Y для второй точки: ");
int y2Coordinate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение Z для второй точки: ");
int z2Coordinate = Convert.ToInt32(Console.ReadLine());


double distance = Distance(x1Coordinate, y1Coordinate, z1Coordinate, x2Coordinate, y2Coordinate, z2Coordinate);
double dRound = Math.Round(distance, 2, MidpointRounding.ToZero);

Console.WriteLine($"Расстояние между заданными точками = {dRound}");

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int x = x2 - x1;
    int y = y2 - y1;
    int z = z2 - z1;
    int sum = x * x + y * y + z * z;

    double result = Math.Sqrt(sum);

    return result;
}




// int x1 = ReadInt("Введите координату X первой точки: ");
// int y1 = ReadInt("Введите координату Y первой точки: ");
// int z1 = ReadInt("Введите координату Z первой точки: ");
// int x2 = ReadInt("Введите координату X второй точки: ");
// int y2 = ReadInt("Введите координату Y второй точки: ");
// int z2 = ReadInt("Введите координату Z второй точки: ");

// int A = x2 - x1;
// int B = y2 - y1;
// int C = z1 - z2;

// double length = Math.Sqrt(A * A + B * B + C * C);
// Console.WriteLine($"Длинна отрезка {length}");


// // Функция ввода сообщения
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }
