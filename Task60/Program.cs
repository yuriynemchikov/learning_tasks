// Составить частотный словарь элементов двумерного массива

void FillArray(int[,] Array1)
{
    for (int i = 0; i < Array1.GetLength(0); i++)
    {
        for (int column = 0; column < Array1.GetLength(1); column++)
        {
            Array1[i, column] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] Array2)
{
    for (int k = 0; k < Array2.GetLength(0); k++)
    {
        for (int l = 0; l < Array2.GetLength(1); l++)
        {
            Console.Write(Array2[k, l] + " ");
        }
        Console.WriteLine();
    }
}

bool CheckIfRepeated (int[,] Array4, int rowExternal, int colExternal)
{
    int ExternalItem = Array4[rowExternal, colExternal];
    for (int row = 0; row < rowExternal; row++)
    {
        for (int column = 0; column < Array4.GetLength(1); column++)
        {
            if (ExternalItem == Array4[row,column])
                    return true; // true means the item is repeated
        }
    }

    for (int column = 0; column < colExternal; column++)
    {
        if (ExternalItem == Array4[rowExternal,column])
                return true; // true means the item is repeated
    }

    return false; // false means the item is NOT repeated
}

int countItemFrequency(int[,] Array, int item)
{
    int count = 0;
    for (int row = 0; row < Array.GetLength(0); row++)
    { 
        for (int col = 0; col < Array.GetLength(1); col++)
        {
            if(Array[row,col] == item)
                count++;
        }
    }
    return count;
}

void PrintFrequency(int[,] Array3)
{ 
    for (int row = 0; row < Array3.GetLength(0); row++)
    { 
        for (int col = 0; col < Array3.GetLength(1); col++)
        {
            bool repeated = CheckIfRepeated(Array3, row, col);
            if (!repeated) 
            {
               int item = Array3[row, col];
               int count = countItemFrequency(Array3, item);
               Console.WriteLine($"Frequency of {item} if {count}");
            }
        }
    }
}

Console.Clear();

Console.WriteLine("Please enter number of rows");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter number of columns");
int columns = int.Parse(Console.ReadLine());


Console.WriteLine();

int[,] doubleArray = new int[rows, columns];

FillArray(doubleArray);
PrintArray(doubleArray);
Console.WriteLine();
PrintFrequency(doubleArray);