// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

Console.Write("Enter number of rows: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Enter number of columns: ");
int columns = int.Parse(Console.ReadLine());

Console.Write("Enter the number you want to find: ");
int findNumber = int.Parse(Console.ReadLine());

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

int sumOfFindNumbers = 0;

void PrintDoubleArray(int[,] doubleArray)
{
    for(int i = 0; i < doubleArray.GetLength(0); i++)
    {
        for(int j = 0; j < doubleArray.GetLength(1); j++)
        {
            if(doubleArray[i, j] == findNumber)
            {
                Console.Write($"Заданное число находится на строке {i+1}, столбец {j+1}"); 
                sumOfFindNumbers += 1;
                Console.WriteLine();
            }   
        }
    }    
}

FillDobleArray(doubleArray);
PrintDoubleArray(doubleArray);

if(sumOfFindNumbers == 0) Console.WriteLine("Заданного числа в данном массиве нет");

