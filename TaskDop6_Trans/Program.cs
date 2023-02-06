// Задание дополнительное - транспонирование

// Задана матрица N на M
// Требуется транспонировать ее относительно горизонтали.


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

void TranspMatrix(int[,] matrix)
{
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0) / 2 + matrix.GetLength(0) % 2; j++)
        {
            temp = matrix[j, i];
            matrix[j, i] = matrix[matrix.GetLength(0)- j - 1, i];
            matrix[matrix.GetLength(0)- j - 1, i] = temp;
        } 
    }
}


Console.Clear();
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
TranspMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix);