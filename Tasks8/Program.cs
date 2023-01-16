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
