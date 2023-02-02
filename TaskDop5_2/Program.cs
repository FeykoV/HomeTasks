Console.Clear();
Console.Write("Введите X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите X3: ");
int x3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y3: ");
int y3 = Convert.ToInt32(Console.ReadLine());
double area = 0;
double p = 0;

double a = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y1 - y2, 2)), 2);
double b = Math.Round(Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y3 - y2, 2)), 2);
double c = Math.Round(Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y1 - y3, 2)), 2);
p = (a + b + c) / 2;
area =Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 2);

Console.WriteLine($"Площадь треугольника: {area} см2");
