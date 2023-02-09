// Задача 60. 
//...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void InputMatrix(int[,,] matrix)
{
    matrix[0, 0, 0] = new Random().Next(10, 100);
    int[] temp = new int[99]; int number = 0; int m = 0; int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int n = 0; n < matrix.GetLength(2); n++)
            {
                number = new Random().Next(10, 100);
                count = 0;
                while (m < 100 && count == 0)
                {
                    if (temp[m] == number)
                    {
                        number = new Random().Next(10, 100);
                        m++;
                    }
                    else
                    {
                        matrix[i, j, n] = number;
                        temp[m] = number;
                        count = 1;
                    }

                }
            }
        }
    }
}

    void PrintMatrix(int[,,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int n = 0; n < matrix.GetLength(2); n++)
                {
                    Console.Write($"{matrix[i, j, n]} ({i},{j},{n}) \t");
                }
                Console.WriteLine();
            }
        }
    }


    Console.Clear();
    Console.Write("Введите размеры массива: ");
    int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
    int[,,] matrix = new int[size[0], size[1], size[2]];
    Console.WriteLine("Трехмерная матрица двухзначных чисел: ");
    InputMatrix(matrix);
    PrintMatrix(matrix);
