// Задача 62: Заполните спирально массив 4 на 4.
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

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
Console.WriteLine("Заполните спирально массив 4 на 4.");
int[,] matrix = new int[4, 4];
int temp = 1;
int i = 0;
int j = 0;

for (temp = 1; temp <= 16; temp++)
{
    matrix[i, j] = temp;
    if (i <= j + 1 && i + j < 3)
        j++;
    else if (i < j && i + j >= 3)
        i++;
    else if (i >= j && i + j > 3)
        j--;
    else
        i--;
}

PrintMatrix(matrix);
