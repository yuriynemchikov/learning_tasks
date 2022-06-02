// Найти кубы чисел от 1 до N
int N = new Random().Next(1,10);
Console.WriteLine($"Вывод кубов чисел от 1 до {N}");

for(int i = 1; i <= N; i++)
{
    Console.WriteLine($"{i} в степени 3 = {i*i*i}");
}
Console.WriteLine();
