// Написать программу замены элементов массива на противоположные

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

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]*-1}, ");
    }
}

FillArray(array);
PrintArray(array);
Console.WriteLine();
