// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] massiv = new int[123];

void FillArray(int[] massiv)
{
    for(int i = 0; i < massiv.Length; i++)
    {
        massiv[i] = new Random().Next(1, 999);
        Console.Write($"{massiv[i]}, ");
    }
    Console.WriteLine();
}

int number = 0;
Console.WriteLine($"Найти кол-во элементов из отрезка [10,99] в массиве");

void PrintArray(int[] array)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        if(massiv[i] <= 99 && massiv[i] >= 10) number += 1;
    }
}

FillArray(massiv);
PrintArray(massiv);
Console.WriteLine($"Кол-во = {number}");

