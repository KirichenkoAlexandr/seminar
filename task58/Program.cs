// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить
//  произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] GetMatrix(int m, int n) 
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(2,5);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],6}");
        }
        Console.WriteLine();
    }
}
bool AreMultipliableMatrices(int[,] matrix1, int[,] matrix2)
{
    return matrix1.GetLength(1) == matrix2.GetLength(0);
}

int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    if (!AreMultipliableMatrices(matrix1, matrix2)) return null!;

    int commonDimension = matrix1.GetLength(1); 
    int rowsProduct = matrix1.GetLength(0);
    int columnsProduct = matrix2.GetLength(1);
    int[,] multiplicationProduct = new int[rowsProduct, columnsProduct];

    for (int i = 0; i < rowsProduct; i++)
    {
        for (int j = 0; j < columnsProduct; j++)
        {
            for (int k = 0; k < commonDimension; k++)
            {
                multiplicationProduct[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }

    return multiplicationProduct;
}

Console.WriteLine("first matrix:");
int[,] firstMatrix = GetMatrix(2,2);
PrintMatrix(firstMatrix);

Console.WriteLine();
Console.WriteLine("Second matrix:");
int[,] secondMatrix = GetMatrix(2,2);
PrintMatrix(secondMatrix);


int [,]resultMatrix=MultiplyMatrices(firstMatrix, secondMatrix);
if (resultMatrix == null)
    {
    Console.WriteLine("\nIncompatible matrices.");
    return;
    }

Console.WriteLine();
Console.WriteLine("\nThe multiplication product is:", resultMatrix);
PrintMatrix(resultMatrix);



