// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

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

double sumOfColumn = 0;
double average = 0;

void MainDiagonal(int[,] doubleArray)
{
    for(int columns = 0; columns < doubleArray.GetLength(1); columns++)
    {
        for(int rows = 0; rows < doubleArray.GetLength(0); rows++)
        {
            sumOfColumn += doubleArray[rows, columns];
        }  
        average = sumOfColumn / doubleArray.GetLength(0);
        Console.WriteLine($"Среднее арифметическое столбца {columns+1} = {average}");
        sumOfColumn = 0;
    }    
}

FillDobleArray(doubleArray);
MainDiagonal(doubleArray);
