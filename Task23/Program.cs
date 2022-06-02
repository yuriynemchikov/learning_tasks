// Показать таблицу квадратов чисел от 1 до N 

int N = new Random().Next(1,100);
Console.WriteLine($"Вывод квадратов чисел от 1 до {N}");

for(int i = 1; i <= N; i++)
{
    Console.WriteLine($"{i}*{i} = {i*i}");
}
Console.WriteLine();

