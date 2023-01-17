Console.Clear();
Console.Write("Введите число 1: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA % numberB == 0) 
Console.WriteLine($"Числа кратные");
else Console.WriteLine($"Числа не кратные, остаток {numberA % numberB} ");