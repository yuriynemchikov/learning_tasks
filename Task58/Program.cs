// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить

Console.Write("Enter number of rows: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Enter number of columns: ");
int columns = int.Parse(Console.ReadLine());

if (rows != columns)
{
    Console.WriteLine("Please, enter equal number of rows and columns");
}
else
{
    int[,] doubleArray = new int[rows, columns];
    void FillDobleArray(int[,] doubleArray)
    {
        for (int i = 0; i < doubleArray.GetLength(0); i++)
        {
            for (int j = 0; j < doubleArray.GetLength(1); j++)
            {
                doubleArray[i, j] = new Random().Next(1, 10);
                Console.Write(doubleArray[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    FillDobleArray(doubleArray);
    Console.WriteLine();

    int[,] changeArray = new int[rows, columns];

    for (rows = 0; rows < doubleArray.GetLength(0); rows++)
    {
        for (columns = 0; columns < doubleArray.GetLength(1); columns++)
        {
            changeArray[rows, columns] = doubleArray[columns, rows];
            Console.Write(doubleArray[columns, rows] + " ");

        }
        Console.WriteLine();
    }
}



