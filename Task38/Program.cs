// Найти сумму чисел одномерного массива стоящих на нечетной позиции

int[] array = new int[10];

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

int sum = 0;


void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0) sum += array[i];
    }
}

FillArray(array);
PrintArray(array);
Console.WriteLine($"Сумма чисел, стоящих на нечетной позиции в массиве = {sum}");

