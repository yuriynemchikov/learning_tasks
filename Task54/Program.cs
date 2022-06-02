// В матрице чисел найти сумму элементов главной диагонали

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

int sumOfDiagonal = 0;

void Diagonal(int[,] doubleArray)
{
    for(int i = 0; i < doubleArray.GetLength(0); i++)
    {
        for(int j = 0; j < doubleArray.GetLength(1); j++)
        {
            if(i == j)
            {
                sumOfDiagonal += doubleArray[i,j];
            }   
        }
    }    
}

FillDobleArray(doubleArray);
Diagonal(doubleArray);

Console.WriteLine($"Сумма элементов главной диагонали матрица равен {sumOfDiagonal}");