// Задача 4

Console.Clear();
Console.Write("Введите число 1: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3: ");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;

if (numberB > max) max = numberB;
if (numberC > max) max = numberC;
Console.WriteLine($"Максимальное число: {max}");