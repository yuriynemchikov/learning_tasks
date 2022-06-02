// Удалить вторую цифру трёхзначного числа

int N = new Random().Next(100, 999);
Console.WriteLine(N);

int first = N/100;
int second = N%10;


Console.Write(first);
Console.Write(second);
