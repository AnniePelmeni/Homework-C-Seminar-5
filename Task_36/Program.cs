// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int CountNumbers(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 > 0) sum = sum + array[i];
    }
    return sum;
}

int[] GenerateArray(int length, int start, int end)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}

int[] array = GenerateArray(10, 1, 99);
Console.Write($"[{String.Join(",", array)}] -> {CountNumbers(array)}");