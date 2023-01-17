// Task 14 1 вариант

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n % 161 == 0)
    Console.WriteLine("yes");
else
    Console.WriteLine("no");

// Task 14 2-й вариант

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n % 7 == 0 && n % 23 == 0)
    Console.WriteLine("yes");
else
    Console.WriteLine("no");