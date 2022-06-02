// Задать массив из 8 элементов и вывести их на экран

int[] array = new int[8];

void FillArray(int[] array1)
{
    int i = 0;
    while (i < array1.Length)
    {
        array1[i] = new Random().Next(1,10);
        i++;
    }
}

void PrintArray(int[] array2)
{
    int j = 0;
    while(j < array2.Length)
    {
        Console.Write(array2[j]);
        j++;
    }
}

PrintArray(array);
Console.WriteLine();
FillArray(array);
PrintArray(array);