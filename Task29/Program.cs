// Задача 29

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран(ввод пользователя с клавиатуры).

Console.Clear();
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите {i}-й элемент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
   
Console.WriteLine($"Результат: [{string.Join(", ", array)}]");