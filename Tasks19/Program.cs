
Console.Clear();
Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 9999 || n > 99999)
{
    Console.Write("Вы ошиблись!\nВведите пятизначное число: ");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n % 10 == n / 10000 && (n / 10) % 10 == (n / 1000) % 10)
    Console.WriteLine($"{n} - это палиндром");
else  
    Console.WriteLine($"{n} - это не палиндром");