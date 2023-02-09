// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Задача 54:

// Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void ReleaseMatrix(int[,] matrix)
{
    int temp = 0; int max = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            max = matrix[i, j];
            for (int n = j; n < matrix.GetLength(1); n++)
            {
                if (matrix[i, n] > max)
                {
                    max = matrix[i, n];
                    temp = matrix[i, n];
                    matrix[i, n] = matrix[i, j];
                    matrix[i, j] = temp;
                }
            }
        }
    }

}


Console.Clear();
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine("Начальная матрица: ");
InputMatrix(matrix);
PrintMatrix(matrix);
ReleaseMatrix(matrix);
Console.WriteLine("Отсортированная матрица: ");
PrintMatrix(matrix);