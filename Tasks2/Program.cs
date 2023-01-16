// Задача 2

Console.Clear();
Console.Write("Введите число 1: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
    Console.WriteLine($"Максимальное число: {numberA}");
if (numberA == numberB)
   Console.WriteLine($"Числа равны {numberA} = {numberB}");
else if (numberA < numberB)
    Console.WriteLine($"Максимальное число: {numberB}");

