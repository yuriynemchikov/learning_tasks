// Показать двумерный массив размером m×n заполненный вещественными числами

Console.Write("Enter number of rows: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Enter number of columns: ");
int columns = int.Parse(Console.ReadLine());

double[,] doubleArray = new double[rows, columns];

void FillDobleArray(double[,] doubleArray)
{
    for(int i = 0; i < doubleArray.GetLength(0); i++)
    {
        for(int j = 0; j < doubleArray.GetLength(1); j++)
        {
            doubleArray[i,j] = new Random().Next(-10,10) + new Random().NextDouble();
        }

    }
}

void PrintDoubleArray(double[,] doubleArray)
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