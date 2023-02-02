// Задание 36 (37)
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.


void InputArray(int[] array) 
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-99, 100); 
}

int ReleaseArray(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
        sum = sum + array[i];
    return sum;
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {ReleaseArray(array)}");