// Задание 8

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = 2;
while (m <= n)
{
    Console.Write($"{m} ");
    m = m + 2; 
}
// Task 8
// тоже через цикл for
//Console.Clear();
//Console.Write("Введите число: ");
//int n = Convert.ToInt32(Console.ReadLine());
//for (int i = 2; i <= n; i += 2) // (begin, condition, step)
//    Console.Write($"{i} ");