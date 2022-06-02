// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

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
            Console.Write(doubleArray[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintDoubleArray(int[,] doubleArray)
{
    for(int i = 0; i < doubleArray.GetLength(0); i++)
    {
        for(int j = 0; j < doubleArray.GetLength(1); j++)
        {
            if(i % 2 == 0 && j % 2 == 0)
            {
                Console.Write(doubleArray[i, j] * doubleArray[i, j] + " "); 
            }  
            else
            {
                Console.Write(doubleArray[i, j] + " ");
            }  
        }
        Console.WriteLine();
    }    
}

FillDobleArray(doubleArray);
PrintDoubleArray(doubleArray);
