// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int CountEvenNumbers(int[] array)
{
    int quantity = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) quantity++;
    }
    return quantity;
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

int[] array = GenerateArray(10, 100, 999);
Console.Write($"[{String.Join(",", array)}] -> {CountEvenNumbers(array)}");
