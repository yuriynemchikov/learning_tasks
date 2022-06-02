// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

int[] array = new int[12];

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 9);
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

int sumPositive = 0;
int sumNegative = 0;

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) sumPositive += array[i];
        else sumNegative += array[i];
    }
}

FillArray(array);
PrintArray(array);
Console.WriteLine($"Сумма положительных чисел массива = {sumPositive}");
Console.WriteLine($"Сумма отрицательных чисел массива = {sumNegative}");