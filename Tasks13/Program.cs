Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n;
while (n1 > 999)
    {
       n1 = n1 / 10;
    }
if (n < 100) Console.WriteLine("Третьей цифры нет");
else Console.WriteLine($"Третья цифра числа:  {n1 % 10}");
