// Показать четные числа от 1 до N

Console.Write("Our number is ");
int N = new Random().Next(1,100);
Console.WriteLine(N);
int Num = 1;

while (Num <= N)
{
    if (Num %2== 0)
    {
        Console.WriteLine(Num);
        Num = Num + 2;
    }
    else
    {
        Num++;
    }
}