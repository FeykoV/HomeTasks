// Задание 58

// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Введите размеры (квадратного) массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrixA = new int[size[0], size[1]];
int[,] matrixB = new int[size[0], size[1]];
int[,] AxB = new int[size[0], size[1]];
Console.WriteLine("Начальный массив А: ");
InputMatrix(matrixA);
PrintMatrix(matrixA);
Console.WriteLine("Начальный массив B: ");
InputMatrix(matrixB);
PrintMatrix(matrixB);

for (int i = 0; i < matrixA.GetLength(0); i++)
{
    for (int j = 0; j < matrixA.GetLength(1); j++)
    {
        for (int n = 0; n < matrixA.GetLength(1); n++)
        {
            AxB[i, j] = AxB[i, j] + matrixA[i, n] * matrixB[n, j];
        }
    }
}

Console.WriteLine("Произведение массива А на массив B: ");
PrintMatrix(AxB);
