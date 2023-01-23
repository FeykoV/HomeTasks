// Дополнительное задание про кусты и ягоды

Console.Clear();
Console.Write("Введите количество кустов на грядке: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int[] sam = new int[n];
int max = 0;

for(int i = 0; i < n; i++)
{
    Console.Write($"Введите количество ягод на {i+1} кустe: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

 sam[0] = array[n-2] + array[n-1] + array[0];
 sam[1] = array[n-1] + array[0] + array[1];

for(int x = 2; x < n; x++)
{
  sam[x] = array[x-2] + array[x-1] + array[x];
}

for(int y = 0; y < n; y++)
{
  if(sam[y] > max) max = sam[y];
}

Console.WriteLine($"максимальное число ягод, которые собирает модуль: {max}");
 