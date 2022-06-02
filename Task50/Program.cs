// В двумерном массиве n×k заменить четные элементы на противоположные

Console.Write("Enter number of rows: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Enter number of columns: ");
int columns = int.Parse(Console.ReadLine());

int[,] doubleArray = new int[rows, columns];

void FillDobleArray(int[,] doubleArray)
{
    for (int i = 0; i < doubleArray.GetLength(0); i++)
    {
        for (int j = 0; j < doubleArray.GetLength(1); j++)
        {
            doubleArray[i, j] = new Random().Next(-10, 10);
        }

    }
}

void PrintDoubleArray(int[,] doubleArray)
{
    for (int i = 0; i < doubleArray.GetLength(0); i++)
    {
        for (int j = 0; j < doubleArray.GetLength(1); j++)
        {
            Console.Write(doubleArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}

FillDobleArray(doubleArray);
PrintDoubleArray(doubleArray);
Console.WriteLine();

for (int i = 0; i < doubleArray.GetLength(0); i++)
{
    for (int j = 0; j < doubleArray.GetLength(1); j++)
    {
        if (doubleArray[i, j] % 2 == 0)
            doubleArray[i, j] *= -1;
        Console.Write(doubleArray[i, j] + " ");
    }
    Console.WriteLine();
}


