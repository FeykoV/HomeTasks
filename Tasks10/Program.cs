Console.Clear();
Console.Write("Введите трёхзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n / 10;
Console.WriteLine($"Вторая цифра числа:  {n1 % 10}");