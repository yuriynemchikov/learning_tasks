// В прямоугольной матрице найти строку с наименьшей суммой элементов.

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

int sum = 0;
int sumMin = 0;
int rowMin = rows;

for(rows = 0; rows < doubleArray.GetLength(0);)
{
    for(columns = 0; columns < doubleArray.GetLength(1); columns++)
    {   
        sumMin += doubleArray[rows, columns];
    }
    break;
}

Console.WriteLine($"Sum of {rows + 1} row = {sumMin}");

for(rows = 1; rows < doubleArray.GetLength(0); rows++)
{
    for(columns = 0; columns < doubleArray.GetLength(1); columns++)
    {
        sum += doubleArray[rows, columns];
    }  
        if (sum < sumMin) 
        {
            sumMin = sum;
            rowMin = rows;
        }  
        Console.WriteLine($"Sum of {rows + 1} row = {sum}");
        sum = 0;
}

Console.WriteLine($"Minimal sum of numbers of a row = {sumMin}");
Console.WriteLine($"The row with a minimal sum of numbers = {rowMin+1}");




