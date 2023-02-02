// Задание 38
// Задайте массив дробных чисел. Найдите разницу между максимальным и минимальным элементов массива.


void InputArray(double[] array) 
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(new Random().NextDouble() * (10 - 1) + 1, 2); 
}

double Max(double[] array) 
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++) 
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

double Min(double[] array) 
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++) 
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double [] array = new double[n];
double result = 0;
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
result = Max(array) - Min(array);
Console.WriteLine($"Разница между максимальным и минимальным элементом = {result}");