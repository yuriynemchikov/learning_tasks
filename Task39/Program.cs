// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.


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

int product = 0;

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length/2; i++)
    {
        product = array[i] * array[array.Length - i - 1];
        Console.WriteLine(product);
    }
}

FillArray(array);
PrintArray(array);

