// Найти произведение двух матриц

Console.Write("Enter number of rows of 1 matrix: ");
int rows1 = int.Parse(Console.ReadLine());

Console.Write("Enter number of columns of 1 matrix: ");
int columns1 = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] matrix1 = new int[rows1, columns1];

int rows2 = columns1;
int columns2 = rows1;

int[,] matrix2 = new int[rows2, columns2];

void FillMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

FillMatrix(matrix1);
Console.WriteLine();
FillMatrix(matrix2);
Console.WriteLine();

int product = 0;
rows2 = 0;

for (rows1 = 0; rows1 < matrix1.GetLength(0); rows1++)
{
    for (columns2 = 0; columns2 < matrix2.GetLength(1); columns2++)
    {
            for (columns1 = 0; columns1 < matrix1.GetLength(1); columns1++)
            {
                product += matrix1[rows1, columns1] * matrix2[rows2, columns2];
                rows2++;
            }
            Console.Write(product + " ");
            rows2 = 0;
            product = 0;

    }
        Console.WriteLine();
}

