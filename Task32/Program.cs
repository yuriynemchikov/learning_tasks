// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 

int[] array = new int[8];

void Fillarray(int[] array)
{
for(int i = 0; i < array.Length; i++)
    {
     array[i] = new Random().Next(0, 2);            
    }
}

void Printarray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
}

Fillarray(array);
Printarray(array);
Console.WriteLine();

