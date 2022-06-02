// Написать программу, которая обменивает элементы первой строки и последней строки

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
}

int temporary = 0;

void Change(int[,] doubleArray)
{
    for(int i = 0; i < doubleArray.GetLength(0); i++)
    {
        for(int j = 0; j < doubleArray.GetLength(1); j++)
        {
            if (i == 0) 
            {
            temporary = doubleArray[doubleArray.GetLength(0)-1, j];
            doubleArray[doubleArray.GetLength(0)-1, j] = doubleArray[i, j];
            doubleArray[i, j] = temporary;
            Console.Write(doubleArray[i, j] + " ");
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
Console.WriteLine();
Change(doubleArray);
