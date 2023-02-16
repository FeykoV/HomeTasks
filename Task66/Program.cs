// Задача 66:

// Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int summa(int n,int m)
{
  if (n < m)
    return 0;
  else return summa(n,m + 1) + m;
}


Console.Clear();
Console.Write("Введите число: M ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: N ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(summa(n,m));
