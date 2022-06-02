// Показать двумерный массив размером m×n заполненный целыми числами

Console.Write("Enter number of rows: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Enter number of columns: ");
int columns = int.Parse(Console.ReadLine());

int[,] doubleArray = new int[rows, columns];

void FillDobleArray(int[,] doubleArray)
{
    for(int i = 0; i < doubleArray.GetLength(0); i++)
    {
        for(int j = 0; j < doubleArray.GetLength(1); j++)
        {
            doubleArray[i,j] = new Random().Next(1,10);
        }

    }
}

void PrintDoubleArray(int[,] doubleArray)
{
    for(int i = 0; i < doubleArray.GetLength(0); i++)
    {
        for(int j = 0; j < doubleArray.GetLength(1); j++)
        {
            Console.Write(doubleArray[i,j] + " ");
        }
        Console.WriteLine();
    }    
}

FillDobleArray(doubleArray);
PrintDoubleArray(doubleArray);