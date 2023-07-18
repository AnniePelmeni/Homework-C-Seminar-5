// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

void ShowDifference(double[] array)
{
    double max = array[0];
    double min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
        if(array[i] < min) min = array[i];
    }
    double diff = Math.Round(max - min, 2);
    Console.WriteLine($"{max} - {min} = {diff}");
}

double[] GenerateArray(int length, double start, double end)
{
    double[] array = new double[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * (end - start) + start, 2);
    }
    return array;
}

double[] array = GenerateArray(10, 1, 99);
Console.Write($"[{String.Join("; ", array)}] => ");
ShowDifference(array);