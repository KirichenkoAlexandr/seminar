// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateMatrixRndInt(int rows, int columns) // rows = 3, columns = 4
{
    //                        0      1      
    int[,] matrix = new int[rows, columns];
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
             matrix[i, j] = i+j;
        }
    }
    return matrix;
}
void randomFilling(int[,]matrix, int min, int max)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }}}
void arithmeticMeanColumn(int[,] matrix)
{
    int sum = 0;
    Console.Write("Arithmetic mean value: ");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        Console.Write(Math.Round((double)sum / matrix.GetLength(0), 1) + "  ");
        sum = 0;
    }
}
void arrayOutput(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "  ");
        }
        Console.WriteLine(" ");
    }
}

int[,] array =  CreateMatrixRndInt(3, 4);
randomFilling(array, 0, 10);
arrayOutput(array);
arithmeticMeanColumn(array);