// Определить, присутствует ли в заданном массиве, некоторое число 

int[] array = new int[8];

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 9);
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

int N = new Random().Next(-9,9);
Console.WriteLine($"Найти число {N} в массиве");

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == N) 
        {
            Console.WriteLine($"В заданном массиве присутствует число {N}");
            break;            
        } 
    }
}

FillArray(array);
PrintArray(array);