// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

double[] array = new double[10];

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() + new Random().Next(-100, 100);
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

FillArray(array);

double max = array[0];
double min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        max = array[i];
    else if (array[i] < min)
        min = array[i];
}



Console.WriteLine($"max element is {max}");
Console.WriteLine($"min element is {min}");


double diff = max - min;
Console.WriteLine(diff);

