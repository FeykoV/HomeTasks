// подсказка
// вводим числа пока n не равно 0
Console.Clear();
int[] array = new int[100];
int n = Convert.ToInt32(Console.ReadLine());
int i = 0;
while (array[i] != 0)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
    i = i + 1;
}

Console.WriteLine(array);
