// Дана последовательность из N целых чисел и число K.
// Необходимо сдвинуть всю последовательность (сдвиг - циклический) 
// на |K| элементов вправо, если K – положительное и влево, если отрицательное. 

Console.Clear();
Console.Write("Введите число К: ");
int k = Convert.ToInt32(Console.ReadLine());
int[] array = { 5, 3, 7, 4, 6 };
int[] array1 = { 0, 0, 0, 0, 0 };
int n = array.Length;
int j = k;
if (k >= 0)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i <= k - 1)
        {
            array1[i] = array[array.Length - j];
            j = j - 1;
        }
        else array1[i] = array[i - k];
    }
}
else
{
    k = k * -1;
    j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - k)
            array1[i] = array[i + k];
        else
        {
            array1[i] = array[j];
            j++;
        }
    }
}
Console.WriteLine($"Результат: [{string.Join(", ", array1)}]");
