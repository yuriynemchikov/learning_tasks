// // 47. Написать программу копирования массива

int[] Array = new int[10];

void FillArray(int[] Array1)
{
    for(int i=0; i < Array1.Length; i++)
    {
        Array1[i] = new Random().Next(1,10);
        Console.Write(Array1[i] + " ");
    }
}

FillArray(Array);

int[] Array3 = new int[10];

void CopyArray(int[] Array2)
{
    for(int j = 0; j < Array2.Length; j++)
    {
        Array3[j] = Array2[j];
        Console.Write(Array3[j] + " ");
    }
}

// Array[3] = 10;

Console.WriteLine();
CopyArray(Array);
