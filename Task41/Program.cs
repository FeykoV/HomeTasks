// Задание 41
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


void ReleaseArray(int[] array)
{
    int count = 0;
    foreach (int element in array) 
        if (element > 0)
            count = count + 1;
    Console.WriteLine($"Положительных чисел: {count}");

}

Console.Clear();
Console.Write("Введите числа (через пробел): ");
int[] array = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
ReleaseArray(array);
