// Показать вторую цифру трёхзначного числа

int N = new Random().Next(100, 999);
Console.WriteLine(N);

N = N%100;
N = N/10;

Console.WriteLine(N);