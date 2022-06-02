// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] array = new int[10];

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 999);
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

int evenNumber = 0;
int oddNumber = 0;

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) evenNumber += 1;
        else oddNumber += 1;
    }
}

FillArray(array);
PrintArray(array);
Console.WriteLine($"Количество четных чисел в массиве = {evenNumber}");
Console.WriteLine($"Сумма нечетных чисел в массиве = {oddNumber}");