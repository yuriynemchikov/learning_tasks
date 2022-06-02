// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

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

FillDobleArray(doubleArray);
Console.WriteLine();

for(rows = 0; rows < doubleArray.GetLength(0); rows++)
{
    for(columns = 0; columns < doubleArray.GetLength(1); columns++)
    {
        for(int j = columns+1; j < doubleArray.GetLength(1); j++)
        {
            if(doubleArray[rows, columns] < doubleArray[rows, j])
            {
                int temorary = doubleArray[rows, columns];
                doubleArray[rows, columns] = doubleArray[rows, j];
                doubleArray[rows, j] = temorary;
            }
        }    
        Console.Write(doubleArray[rows, columns] + " ");
    }
    Console.WriteLine();
}

